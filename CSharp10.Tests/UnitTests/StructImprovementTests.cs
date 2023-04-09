namespace CSharp10.Tests.UnitTests;

[TestClass]
public class StructImprovementTests
{
    [TestMethod]
    public void ParameterLessConstructorTests()
    {
        // Arrange
        var sut = new ParameterlessConstructorStruct();
        var expectedX = 5;
        var expectedY = 10;

        // Act
        var actualX = sut.X;
        var actualY = sut.Y;

        // Assert
        Assert.AreEqual(expectedY, actualY);
        Assert.AreEqual(expectedX, actualX);
    }

    [TestMethod]
    public void FieldInitializerTests()
    {
        // Arrange
        var sut = new FieldInitializerStruct();
        var expectedX = 5;
        var expectedY = 10;

        // Act
        var actualX = sut.X;
        var actualY = sut.Y;

        // Assert
        Assert.AreEqual(expectedY, actualY);
        Assert.AreEqual(expectedX, actualX);
    }

    [TestMethod]
    public void WithExpressionTest()
    {
        // Arrange
        var source = new FieldInitializerStruct();

        // Act
        var dest = source with { X = 10, Y = 15 };

        // Assert
        Assert.AreEqual(5, source.X);
        Assert.AreEqual(10, source.Y);
        Assert.AreEqual(10, dest.X);
        Assert.AreEqual(15, dest.Y);
    }

    internal struct ParameterlessConstructorStruct
    {
        public ParameterlessConstructorStruct()
        {
            X = 5;
            Y = 10;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    internal struct FieldInitializerStruct
    {
        public int X { get; set; } = 5;
        public int Y { get; set; } = 10;

        public FieldInitializerStruct()
        {
        }
    }
}
