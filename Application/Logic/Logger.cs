namespace Logic;

public class Logger : ILogger {

    public bool Log(string message) 
    {
        Console.WriteLine(message);
        return true; 
    }
}