namespace TheGame.Classes.Exceptions
{
    using System;

    class NotEnoughEnergyException : Exception
    {
        public NotEnoughEnergyException()
        { }

        public NotEnoughEnergyException(string message)
            : base(message)
        { }

        public NotEnoughEnergyException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
