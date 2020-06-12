using System.Collections.Concurrent;
using NoxLand.Game.Commands;

namespace NoxLand.Game.Execution
{
    public interface ICommandProcessor
    {
        BlockingCollection<ICommand> CommandQueue { get; }

        void BeginProcessing();
        void QueueCommand(ICommand command);
    }
}