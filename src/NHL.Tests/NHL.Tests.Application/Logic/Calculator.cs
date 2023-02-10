using Exceptions;

namespace Logic;

// It's a very basic calculator. It can only divide!
// It's just so we have something to test, and to give a mock to
public class Calculator 
{

    private ILogger _logger;

    // We're passing the logger through the constructor to make testing easier!
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public double Divide(double value, double divisor)
    {
        var result = value/divisor;

        var succes = _logger.Log($"Division happened: {value}/{divisor} = {result}");
        
        // I'll be honest, we only do this so the output of the Logger matters so we can play with it during testing
        if(!succes) {
            throw new LogFailureException("Failed to write to log");
        }
        
        return result;
    }

}