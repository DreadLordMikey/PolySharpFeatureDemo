using CSharp11.Tests.Helpers;

namespace CSharp11.Tests.UnitTests;

[TestClass]
public class NameOfScopeTests
{
    [TestMethod]
    public void Method_WithNameOfScopeAttribute_WorksAsExpected()
    {
        // Arrange
        var sut = new NameOfScopeType();

        // Act
        var type = typeof(NameOfScopeType);
        var methods = type.GetMethods();
        var method = methods.FirstOrDefault(m => m.Name == "MethodWithParameter");
        var attributes = method?.GetCustomAttributes(typeof(NameOfScopeAttribute), false);
        var attribute = attributes?.FirstOrDefault();


        var expectedType = typeof(NameOfScopeAttribute);
        var actualType = attribute?.GetType();

        // Assert
        Assert.IsNotNull(attribute);
        Assert.IsInstanceOfType(attribute, expectedType);
        Assert.AreEqual("parameterName", ((NameOfScopeAttribute)attribute).ParameterName);
    }
}
