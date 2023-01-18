namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class RangeTests
   {
      [TestMethod]
      public void ForArray_GivenBasicRange_ReturnsSlice()
      {
         // Span<T> requires a reference to System.Memory.
         //
         // Also note that ranges provided by the polyfill do not work
         // on arrays. Instead, you must convert them to a Span<T>.

         // Arrange
         Span<int> numbers = new[] { 0, 10, 20, 30, 40, 50 };
         int margin = 1;
         // Act

         var inner = numbers[margin..^margin];

         // Assert
         Assert.AreEqual(10, inner[0]);
         Assert.AreEqual(20, inner[1]);
         Assert.AreEqual(30, inner[2]);
         Assert.AreEqual(40, inner[3]);
      }

      [TestMethod]
      public void ForArrayOfString_GivenRangeToLastItem_ReturnsLastItem()
      {
         // Arrange
         string line = "one two three";
         int amountToTakeFromEnd = 5;
         var expected = "three";

         // Act
         Range endIndices = ^amountToTakeFromEnd..^0;
         string actual = line[endIndices];

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void ForRange_WithOpenEnd_ReturnsAllItemsToEnd()
      {
         // Arrange
         Span<int> numbers = new[] { 0, 10, 20, 30, 40, 50 };
         int amountToDrop = numbers.Length / 2;

         // Act
         Span<int> rightHalf = numbers[amountToDrop..];

         // Assert
         Assert.AreEqual(30, rightHalf[0]);
         Assert.AreEqual(40, rightHalf[1]);
         Assert.AreEqual(50, rightHalf[2]);
      }

      [TestMethod]
      public void ForRange_WithOpenStart_ReturnsAllItemsFromStart()
      {
         // Arrange
         Span<int> numbers = new[] { 0, 10, 20, 30, 40, 50 };
         int amountToDrop = numbers.Length / 2;

         // Act
         Span<int> leftHalf = numbers[..^amountToDrop];

         // Assert
         Assert.AreEqual(0, leftHalf[0]);
         Assert.AreEqual(10, leftHalf[1]);
         Assert.AreEqual(20, leftHalf[2]);
      }

      [TestMethod]
      public void WithArray_ForAllRangeOperators_ReturnSlice()
      {
         // Arrange
         int[] oneThroughTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

         // Act

         // Assert
         AssertRange(oneThroughTen, .., oneThroughTen);
         AssertRange(oneThroughTen, ..3, new[] { 1, 2, 3,});
         AssertRange(oneThroughTen, 2..^0, new[] { 3, 4, 5, 6, 7, 8, 9, 10 });
         AssertRange(oneThroughTen, 3..5, new[] { 4, 5 });
         AssertRange(oneThroughTen, ^2..^0, new[] { 9, 10 });
         AssertRange(oneThroughTen, 0..^3, new[] { 1, 2, 3, 4, 5, 6, 7 });
         AssertRange(oneThroughTen, 3..^4, new[] { 4, 5, 6 });
         AssertRange(oneThroughTen, ^4..^2, new[] { 7, 8 });
      }

      private void AssertRange(Span<int> ints, Range range, int[] expected)
      {
         var actual = ints[range];

         for(var i = 0; i < expected.Length; i++)
         {
            Assert.AreEqual(expected[i], actual[i]);  
         }
      }
      
   }
}
