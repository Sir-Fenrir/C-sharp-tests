namespace Exceptions;

// This is just a class to have a specific type of exception
public class LogFailureException : Exception
{
    public LogFailureException(string message) : base(message)
    {
    }
}