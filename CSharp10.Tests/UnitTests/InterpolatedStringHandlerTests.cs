using PolySharpFeatureTests.Helpers;

namespace CSharp10.Tests.UnitTests;

[TestClass]
public class InterpolatedStringHandlerTests
{
    [TestMethod]
    public void LogArg_OfDateTime_IsProperlyFormatted()
    {
        // Arrange
        var logger = new Logger() { EnabledLevel = LogLevel.Error };
        var time = DateTime.Now;

        // Act
        var actual = logger.LogMessage(LogLevel.Error, $"Error Level. Current time: {time}. This is an error. It will be printed.");

        // Assert
        Assert.IsTrue(actual.Contains("Error Level. Current time: "));
        Assert.IsTrue(actual.Contains(". This is an error. It will be printed."));
        Assert.IsTrue(actual.Contains("AppendFormatted called"));
    }

    [TestMethod]
    public void LogArg_OfString_IsProperlyFormatted()
    {
        // Arrange
        var logger = new Logger() { EnabledLevel = LogLevel.Error };
        var time = DateTime.Now.ToString("MMMM");

        // Act
        var actual = logger.LogMessage(LogLevel.Error, $"Error Level. Current month: {time}. This is an error. It will be printed.");

        // Assert
        Assert.IsTrue(actual.Contains("Error Level. Current month: "));
        Assert.IsTrue(actual.Contains(". This is an error. It will be printed."));
        Assert.IsTrue(actual.Contains("AppendLiteral called"));
    }
}
