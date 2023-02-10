namespace Application.Tests;

using Logic;
using Exceptions;
using NSubstitute;

[TestFixture]
public class Tests
{

    private ILogger mockLogger;
    private Calculator calculator;
    
    // This method is called before EVERY test in this class!
    // So we always have a clean mock for our Logger.
    [SetUp]
    public void Setup()
    {
        // We create a mock using the library 'NSubstitute'
        mockLogger = Substitute.For<ILogger>();
        calculator = new Calculator(mockLogger);
    }

    [Test]
    public void Test_Exception_On_Logging_Failure()
    {
        // Arrange
        mockLogger
            .Log(Arg.Any<string>()) // We're instructing the mock that anytime it receives an argument of type string (only option)
            .Returns(false); // it should return false. We could also check for specific inputs, not just type.

        // Assert
        Assert.Throws<LogFailureException>(
                // Act
                () => calculator.Divide(1, 1)
            ); // Now we're asserting that an exception is thrown
        // You might think that it's in the wrong order, you should act first, then assert.
        // That is correct, but that still happens. In this exceptional (ha!) case, we need to define the act and give it
        // to the testing framework, so it can execute the act for us in such a manner that it can later assert whether the exception
        // is thrown.
    }

    [Test]
    public void Test_Successful_Division()
    {
        // Arrange
        mockLogger.Log(Arg.Any<string>())
            .Returns(true); // This time, we're testing what happens when logging goes well, so we return true  

        // Act
        var result = calculator.Divide(20, 4);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}