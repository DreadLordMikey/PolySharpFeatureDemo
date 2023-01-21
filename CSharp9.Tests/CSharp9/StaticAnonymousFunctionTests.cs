using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class StaticAnonymousFunctionTests
    {
        [TestMethod]
        public void Static_Lambda_ReturnsExpectedValue()
        {
            // Arrange
            int[] data = new[] { 1, 2, 3 };
            var expected = 2;

            // Act
            int actual = data.Where(static x => x == 2).First();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Static_Function_ReturnsExpectedValue()
        {
            // Arrange
            string DisplayData(Func<string, string> func)
            {
                return func("Hello, World!");
            }
            var expected = "hello, world!";

            // Act
            var actual = DisplayData(static text => text.ToLower());

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
