using PolySharpFeatureTests.Helpers;

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
        public void PropertyPattern_WithMatchingPattern_ReturnsMatch()
        {
            // Arrange
            var points = new[] {new Point(0, 0),
            new Point(5, 10),
            new Point(6, 5),
            new Point(5, 11) };

            // Act
            var actual = points.Where(p => p is { X: 5 or 6, Y: 10 or 11 or 12 }).ToList();

            // Assert
            Assert.AreEqual(2, actual.Count);
            Assert.IsTrue(actual.Any(p => p.X == 5 && p.Y == 10));
            Assert.IsTrue(actual.Any(p => p.X == 5 && p.Y == 11));
        }

        [TestMethod]
        public void RelationalPattern_WithMatch_ReturnsMatch()
        {
            // Arrange

            static string Classify(double measurement) => measurement switch
            {
                < -4.0 => "Too low",
                > 10.0 => "Too high",
                double.NaN => "Unknown",
                _ => "Acceptable",
            };

            // Act

            // Assert
            Assert.AreEqual("Too high", Classify(13));
            Assert.AreEqual("Unknown", Classify(double.NaN));
            Assert.AreEqual("Acceptable", Classify(2.4));
        }

        [TestMethod]
        public void ConstantPattern_WithMatch_ReturnsMatch()
        {
            // Arrange
            static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
            {
                1 => 12.0m,
                2 => 20.0m,
                3 => 27.0m,
                4 => 32.0m,
                0 => 0.0m,
                _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
            };

            var prices = new[] { 0.0m, 12.0m, 20.0m, 27.0m, 32.0m };

            // Act
            // Assert
            for (var i = 1; i <= 4; i++)
            {
                Assert.AreEqual(prices[i], GetGroupTicketPrice(i));
            }
        }

        [TestMethod]
        public void Logical_Not_ReturnsMatch()
        {
            // Arrange
            var input = "Hello, World!";
            var expected = true;
            var actual = false;

            // Act
            if (input is not null)
                actual = true;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Logical_And_ReturnsMatch()
        {
            // Arrange
            static string Classify(double measurement) => measurement switch
            {
                < -40.0 => "Too low",
                >= -40.0 and < 0 => "Low",
                >= 0 and < 10.0 => "Acceptable",
                >= 10.0 and < 20.0 => "High",
                >= 20.0 => "Too high",
                double.NaN => "Unknown",
            };

            // Act

            // Assert
            Assert.AreEqual("High", Classify(13));
            Assert.AreEqual("Too low", Classify(-100));
            Assert.AreEqual("Acceptable", Classify(5.7));
        }

        [TestMethod]
        public void Logical_Or_ReturnsMatch()
        {
            // Arrange
            static string GetCalendarSeason(DateTime date) => date.Month switch
            {
                3 or 4 or 5 => "spring",
                6 or 7 or 8 => "summer",
                9 or 10 or 11 => "autumn",
                12 or 1 or 2 => "winter",
                _ => "unknown",
            };

            // Act

            // Assert
            Assert.AreEqual("winter", GetCalendarSeason(new DateTime(2021, 1, 19)));
            Assert.AreEqual("autumn", GetCalendarSeason(new DateTime(2021, 10, 9)));
            Assert.AreEqual("spring", GetCalendarSeason(new DateTime(2021, 5, 11)));
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

        [TestMethod]
        public void PositionaPattern_WitRuntimeTypeCheck_ReturnsMatch()
        {
            // Arrange
            static string MatchPoint(object point) => point switch
            {
                Point2D(> 0, > 0) p => p.ToString(),
                Point3D(> 0, > 0, > 0) p => p.ToString(),
                _ => string.Empty,
            };

            var p2 = new Point2D(1, 1);
            var p3 = new Point3D(1, 1, 1);

            // Assert
            Assert.AreEqual(string.Empty, MatchPoint(new Point2D(0, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point2D(1, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point2D(0, 1)));
            Assert.AreEqual(p2.ToString(), MatchPoint(p2));

            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(0, 0, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(1, 0, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(0, 1, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(0, 0, 1)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(1, 1, 0)));
            Assert.AreEqual(string.Empty, MatchPoint(new Point3D(1, 0, 1)));
            Assert.AreEqual(p3.ToString(), MatchPoint(p3));
        }

    }
}
