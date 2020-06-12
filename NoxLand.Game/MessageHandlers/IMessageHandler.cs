using NoxLand.Game.Entity;

namespace NoxLand.Game.Execution
{
    public interface IMessageHandler
    {
        void HandleMessage(GameInstance game, GameMessage message);
    }
}
