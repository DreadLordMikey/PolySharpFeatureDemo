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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "Microsoft code sample. Preserved for unit test accuracy.")]
        static int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1,
            ICollection<T> collection => 2,
            _ => 3,
        };
    }
}
