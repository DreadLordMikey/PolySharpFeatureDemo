namespace PolySharpFeatureTests.CSharp10;

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
        public Bar Bar { get => new Bar(); }
        public string Value = "Foo";
    }

    private class Bar
    {
        public Baz Baz { get => new Baz(); }
        public string Value = "Bar";
    }

    private class Baz
    {
        public string Value = "Hello, World!";
    }
}
