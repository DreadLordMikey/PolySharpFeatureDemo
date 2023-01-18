namespace PolySharpFeatureTests
{
    [TestClass]
    public class StackAllocTests
    {
        [TestMethod]
        public void ContentsOf_StackAllocArray_AreQueryable()
        {
            // Arrange
            int length = 3;

            // Act
            Span<int> numbers = stackalloc int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }

            // Assert
            Assert.AreEqual(length, numbers.Length);
            Assert.IsTrue(numbers.ToArray().All(n => n >= 0 && n <= 2));
        }

        [TestMethod]
        public void StackAllocArray_InExpression_IsQueryable()
        {
            // Arrange
            int length = 1000;

            // Act
            Span<byte> buffer = length <= 1024 ? stackalloc byte[length] : new byte[length];

            // Assert
            Assert.AreEqual(length, buffer.Length);
            Assert.IsTrue(buffer.ToArray().All(b => b == 0));
        }

        [TestMethod]
        public void StackAlloc_AsArg_ReturnsExpectedResult()
        {
            // Arrange
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var expected = 1;

            // Act
            var actual = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public unsafe void PointerTo_StackAllocArray_IsQueryable()
        {
            // Arrange
            int length = 3;

            // Act
            int* numbers = stackalloc int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }

            // Assert
            Assert.AreEqual(0, numbers[0]);
            Assert.AreEqual(1, numbers[1]);
            Assert.AreEqual(2, numbers[2]);
        }

        [TestMethod]
        public void ArrayInitializerSyntax_WithNoExplicitSize_ReturnsArray()
        {
            // Arrange
            // Act
            Span<int> first = stackalloc int[] { 1, 2, 3 };

            // Assert
            Assert.AreEqual(1, first[0]);
            Assert.AreEqual(2, first[1]);
            Assert.AreEqual(3, first[2]);
        }
    }
}
