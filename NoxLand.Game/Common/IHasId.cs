namespace NoxLand.Game.Common
{
    public interface IHasId<T>
    {
        Id<T> Id
        {
            get;
        }
    }
}
