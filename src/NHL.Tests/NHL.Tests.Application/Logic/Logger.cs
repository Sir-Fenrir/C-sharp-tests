namespace Logic;

// Very simple logger, but we could make variants that write to file,
// and suddenly it's easier to imagine that it can actually fail!
public class Logger : ILogger {

    public bool Log(string message) 
    {
        Console.WriteLine(message);
        return true; 
    }
}