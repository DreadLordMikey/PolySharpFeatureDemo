using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class ExtensionGetEnumeratorSupportTests
    {
        [TestMethod]
        public void EnumeratorExtension()
        {
            // Arrange
            var iterable = new Iterable();
            var expected = new[] { 0, 1, 2, 3, 4 }.Sum();
            var actual = 0;

            // Act
            foreach(var i in iterable)
            {
                actual += i;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Iterable
    {
        public int Current { get; private set; }

        public bool MoveNext()
        {
            if (Current == 4)
                return false;

            Current++;
            return true;
        }
    }

    public static class IIterableExtensions
    {
        public static Iterable GetEnumerator(this Iterable instance) => instance;
    }

}
