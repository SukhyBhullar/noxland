using System;

namespace NoxLand.Game.Common
{
    public struct Id<T>
    {
        private readonly Guid _value;

        public Id(Guid value)
        {
            _value = value;
        }

        public static explicit operator Guid(Id<T> id)
        {
            return id._value;
        }

        public static explicit operator Id<T>(Guid value)
        {
            return new Id<T>(value);
        }

        public static Id<T> NewId()
        {
            return new Id<T>(Guid.NewGuid());
        }

        public Guid Value => _value;

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
