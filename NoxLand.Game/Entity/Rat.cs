using NoxLand.Game.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoxLand.Game.Entity
{
    public class Rat : IHasId<Rat>, IPlaceable
    {
        Id<Rat> IHasId<Rat>.Id => Id<Rat>.NewId();
        public Id<IPlaceable> Id => new Id<IPlaceable>(Id.Value);
    }
}
