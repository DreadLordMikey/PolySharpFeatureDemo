using System.Text;

namespace PolySharpFeatureTests.CSharp10;

[TestClass]
public class SealedRecordOverrideTests
{
    [TestMethod]
    public void Record_WithOverriddenToString_ReturnsExpectedValue()
    {
        // Arrange
        var sut = new Point(5, 10);
        var expected = "Point.X = 5; Point.Y = 10";

        // Act
        var actual = sut.ToString();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Record_WithPrintMembersImpl_ReturnsExpectedValue()
    {
        // Arrange
        var sut = new Rect(5, 10);
        var expected = "Rect { X: 5, Y: 10 }";

        // Act
        var actual = sut.ToString();

        // Assert
        Assert.AreEqual(expected, actual);
    }


    abstract record Shape()
    {
        protected virtual bool PrintMembers(StringBuilder stringBuilder) { return false; }
    }

    private record Rect(int X, int Y) : Shape
    {
        protected override bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"X: {X}, Y: {Y}");
            return true;
        }
    }

    private record Point(int X, int Y)
    {
        public override string ToString()
        {
            return $"Point.X = {X}; Point.Y = {Y}";
        }
    }

}
