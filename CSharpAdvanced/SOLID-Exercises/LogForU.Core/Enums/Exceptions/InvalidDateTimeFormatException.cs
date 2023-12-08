namespace LogForU.Core.Enums.Exceptions
{
    public class InvalidDateTimeFormatException : Exception
    {
        private const string DefaultMessage = "Invalid DateTime format";
        public InvalidDateTimeFormatException()
            : base(DefaultMessage)
        {

        }
        public InvalidDateTimeFormatException(string message)
            : base(message)
        {

        }
    }
}
