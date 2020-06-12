namespace NoxLand.Game.Execution
{
    public interface IMessageReceiver
    {
        void Receive(GameMessage message);
    }
}