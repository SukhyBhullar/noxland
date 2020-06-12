using NoxLand.Game.Commands;
using NoxLand.Game.Common;
using NoxLand.Game.Entity;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NoxLand.Game.Execution
{
    public class Spawner
    {
        private readonly GameInstance _game;
        private readonly Id<Room> _roomId;
        private readonly IMessageSender _messageSender;

        public Spawner(GameInstance game, Id<Room> roomId, IMessageSender messageSender)
        {
            _messageSender = messageSender;
            _game = game;
            _roomId = roomId;
        }

        public void Begin(CancellationToken ctx)
        {
            Task task = new Task(() =>
            {
                while (true)
                {
                    var rat = new Rat();
                    var addToRoom = new AddToRoomCommand(_game, _roomId, rat);
                    var response = new GameMessage(Guid.NewGuid(), MessageVerb.RatCreated,
                        new Dictionary<string, string>
                        {
                            { "Id", rat.Id.ToString() }
                        }
                        );
                    

                    _game.CommandProcessor.QueueCommand(new ReportMessageCommand(_messageSender, addToRoom, response));
                    Thread.Sleep(2000);
                }
            }, ctx);
            
        }
    }
}
