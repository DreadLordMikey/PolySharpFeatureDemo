using CSharp11.Tests.Helpers;

namespace CSharp11.Tests.UnitTests;


[TestClass]
public class GenericAttributeTests
{
    [TestMethod]
    public void Class_WithGenericAttribute_ReflectsAttribute()
    {
        // Arrange
        var sut = new GenericAttributeMethodImpl();
        Type type = typeof(GenericAttributeMethodImpl);

        // Act
        var attribute = sut.GetType()
            .GetCustomAttributes(true)
            ?.Where(a => a.GetType() == type)
            ?.FirstOrDefault();

        // Assert
        Assert.IsNotNull(attribute);
        Assert.AreEqual(type.Name, ((GenericAttributeAttribute<GenericAttributeMethodImpl>)attribute).Name);
    }

    [TestMethod]
    public void Method_WithGenericAttribute_ReflectsAttribute()
    {
        // Arrange
        var sut = new GenericAttributeMethodImpl();

        // Act
        var attribute = sut.GetType()
            .GetMethods()
            .FirstOrDefault()
            ?.GetCustomAttributes(true)
            ?.Where(a => a.GetType() == typeof(GenericAttributeAttribute<string>))
            ?.FirstOrDefault();

        // Assert
        Assert.IsNotNull(attribute);
        Assert.AreEqual("Hello, World!", ((GenericAttributeAttribute<string>)attribute).Name);
    }
}
