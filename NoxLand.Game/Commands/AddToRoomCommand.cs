using NoxLand.Game.Common;
using NoxLand.Game.Entity;

namespace NoxLand.Game.Commands
{
    class AddToRoomCommand: ICommand
    {
        private readonly GameInstance _game;
        private readonly Id<Room> _roomId;
        private IPlaceable _placeable;

        public AddToRoomCommand(GameInstance game, Id<Room> RoomId, IPlaceable Placeable)
        {
            _game = game;
            _roomId = RoomId;
            _placeable = Placeable;
        }

        public void Execute()
        {
            _game.Rooms[_roomId].Placeables.Add(_placeable);
        }
    }
}
