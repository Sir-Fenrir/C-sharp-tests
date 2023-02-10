namespace Exceptions;

public class LogFailureException : Exception
{
    public LogFailureException(string message) : base(message)
    {
    }
}