using CSharp10.Tests.Helpers;

namespace CSharp10.Tests.UnitTests;

[TestClass]
public class CallerArgumentExpressionTests
{
    [TestMethod]
    public void Impl_WhenCalled_ReturnsCallerExpression()
    {
        // Arrange
        var sut = new CallerArgumentExpressionImpl();

        // Act
        var actual = sut.Execute(DateTime.Now == DateTime.MinValue);

        // Assert
        Assert.AreEqual("DateTime.Now == DateTime.MinValue", actual);
    }

}

