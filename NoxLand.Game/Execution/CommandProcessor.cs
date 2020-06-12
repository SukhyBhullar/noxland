using NoxLand.Game.Commands;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace NoxLand.Game.Execution
{
    public class CommandProcessor : ICommandProcessor
    {
        public BlockingCollection<ICommand> CommandQueue
        {
            get; private set;
        }

        public CommandProcessor()
        {
            CommandQueue = new BlockingCollection<ICommand>();
        }

        public void QueueCommand(ICommand command)
        {
            CommandQueue.Add(command);
        }

        public void BeginProcessing()
        {
            Task.Run(() =>
            {
                foreach (var command in CommandQueue.GetConsumingEnumerable())
                {
                    command.Execute();
                }
            });
        }
    }
}
