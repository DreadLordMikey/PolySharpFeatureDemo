namespace CSharp10.Tests.UnitTests;

[TestClass]
public class RecordStructTests
{
    [TestMethod]
    public void RecordStruct_WhenMutable_CanBeMutated()
    {
        // Arrange
#pragma warning disable IDE0017 // Simplify object initialization
        var instance = new MutablePoint();
#pragma warning restore IDE0017 // Simplify object initialization

        // Act
        instance.X = 5;
        instance.Y = 10;
        instance.Z = 15;

        // Assert
        Assert.AreEqual(5, instance.X);
        Assert.AreEqual(10, instance.Y); 
        Assert.AreEqual(15, instance.Z);   
    }

    [TestMethod]
    public void RecordStruct_WhenImmutable_CannotBeMutated()
    {
        // Arrange
        var source = new ImmutablePoint(5, 10, 15);

        // Act            
        var actual = source with { X = 10, Y = 15, Z = 20 };

        // Assert
        Assert.AreEqual(5, source.X);
        Assert.AreEqual(10, source.Y);
        Assert.AreEqual(15, source.Z);
        Assert.AreEqual(10, actual.X);
        Assert.AreEqual(15, actual.Y);
        Assert.AreEqual(20, actual.Z);
    }

    public record struct MutablePoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }


    public readonly record struct ImmutablePoint(double X, double Y, double Z);
}
