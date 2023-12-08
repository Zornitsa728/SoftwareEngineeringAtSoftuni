namespace LogForU.Core.Enums.Exceptions
{
    public class InvalidPathException : Exception
    {

        private const string DefaultMessage = "Path is invalid or empty";
        public InvalidPathException()
            : base(DefaultMessage)
        {

        }

        public InvalidPathException(string message)
            : base(message)
        {

        }
    }
}
