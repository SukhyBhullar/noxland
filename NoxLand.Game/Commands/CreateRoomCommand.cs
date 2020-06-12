using NoxLand.Game.Entity;

namespace NoxLand.Game.Commands
{
    public class CreateRoomCommand : ICreateCommand<Room>
    {
        private readonly GameInstance game;

        public CreateRoomCommand(GameInstance game)
        {
            this.game = game;
        }

        public Room Execute()
        {
            if(game == null)
            {
                throw new GameInstanceIsNull();
            }

            Room newRoom = new Room();
            game.Rooms.Add(newRoom);
            return newRoom;
        }
    }
}