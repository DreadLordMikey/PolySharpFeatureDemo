namespace CSharp10.Tests.UnitTests;

[TestClass]
public class ExtendedPropertyPatternTests
{
    [TestMethod]
    public void ExtendedProperty_WhenQueried_ReturnsExpectedValue()
    {
        // Arrange
        var sut = new Foo();
        const string expected = "Hello, World!";
        string actual = null;

        // Act
        if (sut is Foo { Bar.Baz.Value: expected })
            actual = sut.Bar.Baz.Value;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    private class Foo
    {
#pragma warning disable IDE0090 // Use 'new(...)'
        public Bar Bar { get => new Bar(); }
#pragma warning restore IDE0090 // Use 'new(...)'
        public string Value = "Foo";
    }

    private class Bar
    {
#pragma warning disable IDE0090 // Use 'new(...)'
        public Baz Baz { get => new Baz(); }
#pragma warning restore IDE0090 // Use 'new(...)'
        public string Value = "Bar";
    }

    private class Baz
    {
        public string Value = "Hello, World!";
    }
}
