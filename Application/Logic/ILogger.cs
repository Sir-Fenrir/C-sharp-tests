namespace Logic;

public interface ILogger
{
    // In case of success we return true! Mostly for demonstration purposes, but depending on what you're writing to, it could fail!
    bool Log(string message);
}
