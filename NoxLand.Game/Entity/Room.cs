using NoxLand.Game.Common;

namespace NoxLand.Game.Entity
{
    public class Room: IHasId<Room>
    {
        public Id<Room> Id
        {
            get; private set; 
        }
        
        public Repo<IPlaceable> Placeables
        {
            get; private set;
        }

        public Room()
        {
            Id = Id<Room>.NewId();
            Placeables = new Repo<IPlaceable>();
        }
    }
}
