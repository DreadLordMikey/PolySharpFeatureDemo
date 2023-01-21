using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolySharpFeatureTests.Helpers;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class DisposableRefStructTests
   {
      [TestMethod]
      public void Struct_WhenReleasedByUsingStatement_IsDisposed()
      {
         // Arrange 
         bool actual = false;
         bool expected = true;

         // Act
         using (var s = new DisposableRefStruct(5, 10, () => actual = true)) { }

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Struct_WhenManuallyDisposed_IsDisposed()
      {
         // Arrange 
         bool actual = false;
         bool expected = true;

         var s = new DisposableRefStruct(5, 10, () => actual = true);

         // Act
         s.Dispose();

         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
