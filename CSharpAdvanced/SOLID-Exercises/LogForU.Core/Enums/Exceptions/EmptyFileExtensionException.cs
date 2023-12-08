namespace LogForU.Core.Enums.Exceptions
{
    public class EmptyFileExtensionException : Exception
    {
        private const string DefaultMessage = "File name cannot be null or whitespace";
        public EmptyFileExtensionException()
            : base(DefaultMessage)
        {

        }

        public EmptyFileExtensionException(string message)
            : base(message)
        {

        }
    }
}
