using NoxLand.Game.Common;

namespace NoxLand.Game.Commands
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICreateCommand<T> where T: IHasId<T>
    {
        T Execute();
    }
}