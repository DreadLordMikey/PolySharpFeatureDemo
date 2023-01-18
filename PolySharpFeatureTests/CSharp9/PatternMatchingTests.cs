using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class PatternMatchingTests
    {
        [TestMethod]
        public void TypePattern_WhenMatchesType_ReturnsExpectedValue()
        {
            // Arrange
            object greeting = "Hello, World!";
            var expected = "hello, world!";
            var actual = default(string);

            // Act
            if (greeting is string message)
                actual = message.ToLower();
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypePattern_InSwitchStatement_MatchesPattern()
        {
            // Arrange
            var expected = "hello, world!";
            var actual = default(string);

            // Act
            switch ("Hello, World!")
            {
                case string message:
                    actual = message.ToLower();
                    break;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Switch_OnArrayType_ReturnsExpectedValue()
        {
            // Arrange
            var numbers = new int[] { 10, 20, 30 };
            var expected = 1;
            
            // Act
            var actual = GetSourceLabel(numbers);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Switch_OnListType_ReturnsExpectedValue()
        {
            // Arrange
            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            var expected = 2;

            // Act
            var actual = GetSourceLabel(letters);

            // Assert
            Assert.AreEqual(expected, actual);
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
        public void RelationalPattern_WithMatch_ReturnsExpectedValue()
        {
            // Arrange
            static bool IsLetter(char c) =>
                c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
            
            var expectedM = true;
            var expectedTab = false;

            // Act
            var actualM = IsLetter('m');
            var actualTab = IsLetter('\t');

            // Assert
            Assert.AreEqual(expectedM, actualM);
            Assert.AreEqual(expectedTab, actualTab);
        }

        [TestMethod]
        public void ParenthesizedPattern_WithMatch_ReturnsExpectedValue()
        {
            // Arrange
            static bool IsLetterOrSeparator(char c) =>
                c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
            var expectedM = true;
            var expectedTab = false;

            // Act
            var actualM = IsLetterOrSeparator('m');
            var actualTab = IsLetterOrSeparator('\t');

            // Assert
            Assert.AreEqual(expectedM, actualM);
            Assert.AreEqual(expectedTab, actualTab);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "Microsoft code sample. Preserved for unit test accuracy.")]
        static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1,
            ICollection<T> collection => 2,
            _ => 3,
        };
    }
}
