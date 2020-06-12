using NoxLand.Game.Entity;
using System.Collections.Generic;

namespace NoxLand.Game.Execution
{
    public class MessageReceiver : IMessageReceiver
    {
        private readonly GameInstance _game;
        private readonly Dictionary<MessageVerb, IMessageHandler> _handlers;

        public MessageReceiver(GameInstance game)
        {
            _game = game;
            _handlers = new Dictionary<MessageVerb, IMessageHandler>();
        }

        public void RegisterHandler(MessageVerb verb, IMessageHandler handler)
        {
            _handlers.Add(verb, handler);
        }

        public void Receive(GameMessage message)
        {
            _handlers[message.Verb].HandleMessage(_game, message);
        }
    }
}
