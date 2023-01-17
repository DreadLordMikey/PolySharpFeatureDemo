namespace PolySharpFeatureTests
{
   [TestClass]
   public class IndexTests
   {
      [TestMethod]
      public void ForArray_GivenLastIndex_ReturnsLastElement()
      {
         // Arrange
         int[] xs = new[] { 0, 10, 20, 30, 40 };         
         int expected = 40;

         // Act
         int actual = xs[^1];

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void ForArray_GivenSecondToLastIndex_Succeeds()
      {
         // Arrange
         var lines = new List<string> { "one", "two", "three", "four" };
         var expected = "three";

         // Act
         string actual = lines[^2];

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void ForArray_GivenIndex1_ReturnsFirstItem()
      {
         // Arrange
         string word = "Twenty";
         char expected = 'T';

         // Act
         Index toFirst = ^word.Length;
         char actual = word[toFirst];

         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
