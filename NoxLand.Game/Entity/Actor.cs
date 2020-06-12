using NoxLand.Game.Common;

namespace NoxLand.Game.Entity
{
    public class Actor: IHasId<Actor>
    {
        public Id<Actor> Id
        {
            get; private set;
        }

        public Actor()
        {
            Id = Id<Actor>.NewId();
        }
    }
}
