namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class GetEnumeratorExtensionTests
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
        private int _current = -1;
        private const int _max = 5;

        public int Current { get => _current; }

        public bool MoveNext()
        {
            if (_current == 4)
                return false;

            _current++;
            return true;
        }
    }

    public static class IIterableExtensions
    {
        public static Iterable GetEnumerator(this Iterable instance) => instance;
    }

}
