namespace CSharp10.Tests.UnitTests;

[TestClass]
public class ConstantInterpolatedStringTests
{
    [TestMethod]
    public void Constant_InterpolatedString_ReturnsExpectedValue()
    {
        /*
            Beginning with C# 10, interpolated strings may be constants, if 
            all expressions used are also constant strings. 
         */

        // Arrange
        const string Language = "C#";
        const string Platform = ".NET";
        const string Version = "10.0";
        const string expected = $".NET - Language: C# Version: 10.0";

        // Act
        const string actual = $"{Platform} - Language: {Language} Version: {Version}";

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
