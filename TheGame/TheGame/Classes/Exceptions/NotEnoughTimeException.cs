namespace TheGame.Classes.Exceptions
{
    using System;

    class NotEnoughTimeException : Exception
    {
        public NotEnoughTimeException()
        { }

        public NotEnoughTimeException(string message)
            : base(message)
        { }

        public NotEnoughTimeException(string message, Exception inner)
            : base(message, inner)
        { }
    }

}
