using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class NullCoalescingOperatorTests
   {
      [TestMethod]
      public void Operator_ForNullValue_AssignsNonNullValue()
      {
         // Arrange
         string a = default;
         var b = "Foo";

         var expected = b;

         // Act
         var actual = a ??= b;

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void RightAssociativeOperator_ForNullValues_AssignsNonNullValue()
      {
         // Arrange
         string a = null;
         string b = null;
         string c = "Foo";
         var expected = c;

         // Act
         var actual = a ??= b ??= c;

         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
