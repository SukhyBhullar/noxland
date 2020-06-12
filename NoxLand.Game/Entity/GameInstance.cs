using NoxLand.Game.Common;
using NoxLand.Game.Execution;

namespace NoxLand.Game.Entity
{
    public class GameInstance: IHasId<GameInstance>
    {
        public Id<GameInstance> Id
        {
            get; private set;
        }

        public ICommandProcessor CommandProcessor
        {
            get; private set;
        }

        public Repo<Room> Rooms
        {
            get; private set;
        }

        public GameInstance()
        {
            Id = Id<GameInstance>.NewId();
            Rooms = new Repo<Room>();
            CommandProcessor = new CommandProcessor();
        }
    }
}
