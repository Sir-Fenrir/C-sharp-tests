using Exceptions;

namespace Logic;

public class Calculator 
{

    private ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public double Divide(double value, double divisor)
    {
        var result = value/divisor;

        var succes =_logger.Log($"Division happened: {value}/{divisor} = {result}");

        if(!succes) {
            throw new LogFailureException("Failed to write to log");
        }
        
        return result;
    }

}