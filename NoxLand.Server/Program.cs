using Confluent.Kafka;
using NoxLand.Game.Entity;
using NoxLand.Game.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NoxLand.Server
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Start");

            var ctx = new CancellationTokenSource();
            Task task = new Task(() =>
            {
                var commandProcessor = new CommandProcessor();

                var messageReceiver = new MessageReceiver(new GameInstance());
                messageReceiver.RegisterHandler(MessageVerb.CreateRoom, new CreateRoomMessageHandler(commandProcessor, new MessageSender()));
                commandProcessor.BeginProcessing();


                while (true)
                {
                    Thread.Sleep(1000);
                    SendMessage(messageReceiver);
                }
            }, ctx.Token);

            task.Start();

            Console.ReadLine();
            ctx.Cancel();
        }

        private static void SendMessage(MessageReceiver messageReceiver)
        {
            GameMessage message = new GameMessage(Guid.NewGuid(), MessageVerb.CreateRoom, null);
            Console.WriteLine("Sent");
            Console.WriteLine($"Verb: {message.Verb}, Correlation:{message.CorrelationId}");
            messageReceiver.Receive(message);
        }
    }

    class MessageSender : IMessageSender
    {
        public void SendMessage(GameMessage message)
        {
            Console.WriteLine("Received");
            Console.WriteLine($"Verb: {message.Verb}, Correlation:{message.CorrelationId}, Data: { message.Data.Select((kv) => kv.Key + ":" + kv.Value).Aggregate((acc, next) => acc + "," + next)}");
        }
    }
}

