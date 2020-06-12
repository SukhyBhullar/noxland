using System.Collections.Generic;

namespace NoxLand.Game.Common
{
    public class Repo<T> : Dictionary<Id<T>, T> where T : IHasId<T>
    {
        public void Add(T item)
        {
            Add(item.Id, item);
        }
    }
}
