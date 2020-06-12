using Xunit;
using NoxLand.Game.Commands;
using NoxLand.Game;
using NoxLand.Game.Entity;

namespace NoxLand.GameTests.Commands
{ 
    public class CreateRoomCommandTest
    {
        [Fact]
        public void NullGameInstanceThrowsError()
        {
            var CreateRoomCommand = new CreateRoomCommand(null);
            Assert.Throws<GameInstanceIsNull>(() => CreateRoomCommand.Execute());
        }

        [Fact]
        public void GameInstanceHasRoomCreatedIfEmpty()
        {
            GameInstance game = new GameInstance();
            var CreateRoomCommand = new CreateRoomCommand(game);
            CreateRoomCommand.Execute();
            Assert.Single(game.Rooms.Values);
        }

        [Fact]
        public void GameInstanceHasRoomCreatedWithExistingRooms()
        {
            GameInstance game = new GameInstance();
            game.Rooms.Add(new Room());
            game.Rooms.Add(new Room());

            var CreateRoomCommand = new CreateRoomCommand(game);
            CreateRoomCommand.Execute();
            Assert.Equal(3, game.Rooms.Values.Count);
        }
    }
}
