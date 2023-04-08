using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolySharpFeatureTests.Helpers;
using System;

namespace PolySharpFeatureTests.CSharp8
{
    [TestClass]
    public class PatternMatchingTests
    {

        [TestMethod]
        public void ConstantPattern_InSwitchExpression_MatchesPattern()
        {
            // Arrange
            var expected = 1;

            var value = ConsoleColor.Red;

            // Act
            var actual = value switch
            {
                ConsoleColor.Red => 1,
                ConsoleColor.Green => 2,
                ConsoleColor.Blue => 3,
                _ => 0
            };

            // Assert
            Assert.AreEqual(expected, actual);
        }

#if (NET47 || NET471_OR_GREATER)
        [TestMethod]
        public void Pattern_WithGuard_MatchesPatternAndGuard()
        {
            // Arrange
            var p0 = new Point(0, 0);
            var p1 = new Point(5, 10);
            var p2 = new Point(10, 5);
            var p3 = new Point(5, 5);

            // Act
            var p0Actual = Point.Transform(p0);
            var p1Actual = Point.Transform(p1);
            var p2Actual = Point.Transform(p2);
            var p3Actual = Point.Transform(p3);

            // Assert
            Assert.AreEqual(p0.X, p0Actual.X);
            Assert.AreEqual(p0.Y, p0Actual.Y);

            Assert.AreEqual(p1.X + p1.Y, p1Actual.X);
            Assert.AreEqual(p1.Y, p1Actual.Y);

            Assert.AreEqual(p2.X - p2.Y, p2Actual.X);
            Assert.AreEqual(p2.Y, p2Actual.Y);

            Assert.AreEqual(2 * p3.X, p3Actual.X);
            Assert.AreEqual(2 * p3.Y, p3Actual.Y);
        }

        [TestMethod]
        public void PositionalPattern_WithMatch_ReturnsMatch()
        {
            // Arrange
            static string Classify(Point point) => point switch
            {
                (0, 0) => "Origin",
                (1, 0) => "positive X basis end",
                (0, 1) => "positive Y basis end",
                _ => "Just a point",
            };

            var p1 = new Point(0, 0);
            var p2 = new Point(1, 0);
            var p3 = new Point(0, 1);
            var p4 = new Point(5, 10);

            var expected1 = "Origin";
            var expected2 = "positive X basis end";
            var expected3 = "positive Y basis end";
            var expected4 = "Just a point";

            // Act
            var actual1 = Classify(p1);
            var actual2 = Classify(p2);
            var actual3 = Classify(p3);
            var actual4 = Classify(p4);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);

        }
#endif

    }
}
