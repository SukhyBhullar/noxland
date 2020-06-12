using NoxLand.Game.Commands;
using NoxLand.Game.Entity;

namespace NoxLand.Game.Execution
{
    public class CreateRoomMessageHandler: IMessageHandler
    {
        private readonly ICommandProcessor _commandProcessor;
        private readonly IMessageSender _messageSender;

        public CreateRoomMessageHandler(ICommandProcessor commandProcessor, IMessageSender messageSender)
        {
            _commandProcessor = commandProcessor;
            _messageSender = messageSender;
        }


        public void HandleMessage(GameInstance game, GameMessage message)
        {
            _commandProcessor.QueueCommand(new CreateResponseCommand<Room>
                                          (new CreateRoomCommand(game),
                                          _messageSender,
                                          message.CorrelationId,
                                          MessageVerb.RoomCreated));

        }

    }
}
