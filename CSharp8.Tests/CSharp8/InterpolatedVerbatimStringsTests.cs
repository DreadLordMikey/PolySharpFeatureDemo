using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp8
{
    [TestClass]
    public class InterpolatedVerbatimStringsTests
    {
        [TestMethod]
        public void VerbatimString_StartingWithDollarSign_ReturnsExpectedValue()
        {
            // Arrange
            var x = 5;
            var y = 10;
            var expected = "5 10";

            // Act
            var actual = $@"{x} {y}";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VerbatimString_StartingWithAtSign_ReturnsExpectedValue()
        {
            // Arrange
            var x = 5;
            var y = 10;
            var expected = "5 10";

            // Act
            var actual = @$"{x} {y}";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
