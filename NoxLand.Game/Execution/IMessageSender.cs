namespace NoxLand.Game.Execution
{
    public interface IMessageSender
    {
        void SendMessage(GameMessage message);
    }
}