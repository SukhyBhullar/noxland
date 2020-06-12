using NoxLand.Game.Common;
using NoxLand.Game.Execution;
using System;
using System.Collections.Generic;

namespace NoxLand.Game.Commands
{
    public class CreateResponseCommand<T> : ICommand where T : IHasId<T>
    {
        private readonly ICreateCommand<T> _command;
        private readonly IMessageSender _sender;
        private readonly Guid _correlationId;
        private readonly MessageVerb _verb;

        public CreateResponseCommand(ICreateCommand<T> command, IMessageSender sender, Guid CorrelationId, MessageVerb verb)
        {
            _command = command;
            _sender = sender;
            _correlationId = CorrelationId;
            _verb = verb;
        }

        public void Execute()
        {
            var data = new Dictionary<string, string>();
            data["Type"] = typeof(T).Name;
            data["Id"] = (_command.Execute() as IHasId<T>).Id.ToString();
            _sender.SendMessage(new GameMessage(_correlationId, _verb, data));
        }
    }
}
