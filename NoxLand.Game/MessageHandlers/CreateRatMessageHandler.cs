using NoxLand.Game.Commands;
using NoxLand.Game.Common;
using NoxLand.Game.Entity;
using NoxLand.Game.Execution;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoxLand.Game.MessageHandlers
{
    class CreateRatMessageHandler : IMessageHandler
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly IMessageSender _messageSender;

        public CreateRatMessageHandler(ICommandProcessor commandProcessor, IMessageSender messageSender)
        {
            _commandProcessor = commandProcessor;
            _messageSender = messageSender;
        }

        public void HandleMessage(GameInstance game, GameMessage message)
        {

        }
    }
}
