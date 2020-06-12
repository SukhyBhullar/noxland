using NoxLand.Game.Execution;
using System;

namespace NoxLand.Game.Commands
{
    class ReportMessageCommand : ICommand
    {
        private readonly IMessageSender _messageSender;
        private readonly ICommand _command;
        private readonly GameMessage _message;

        public ReportMessageCommand(IMessageSender messageSender, ICommand command, GameMessage message)
        {
            _messageSender = messageSender;
            _command = command;
            _message = message;
        }

        public void Execute()
        {
            try
            {
                _command.Execute();
                _messageSender.SendMessage(_message);
            }
            catch(Exception)
            {
                //Add exception message
                throw;
            }
            
        }
    }
}
