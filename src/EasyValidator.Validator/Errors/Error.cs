namespace EasyValidator.Validator.Errors
{
    public sealed class Error
    {
        public Error(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }

    }
}
