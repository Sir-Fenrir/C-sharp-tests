namespace Application.Tests;

using Logic;
using Exceptions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

public class Tests
{

    private ILogger mockLogger;
    private Calculator calculator;
    
    [SetUp]
    public void Setup()
    {
        mockLogger = Substitute.For<ILogger>();
        calculator = new Calculator(mockLogger);
    }

    [Test]
    public void Test_Exception_On_Logging_Failure()
    {
        mockLogger.Log(Arg.Any<string>()).Returns(false);
        Assert.Throws<LogFailureException>(() => calculator.Divide(1, 1));
    }

    [Test]
    public void Test_Successful_Division()
    {
        mockLogger.Log(Arg.Any<string>()).Returns(true);
        var result = calculator.Divide(20, 4);
        Assert.That(result, Is.EqualTo(5));
    }
}