#nullable enable

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class NullableReferenceTypesTests
   {
      /*
       * The majority of nullable reference type behavior is provided at compile time.
       * 
       * When nullable enable is set:
       * 
       *    1. Reference types are non-nullable. That is, they cannot be set to null.
       *    2. Variables that use the nullable operator (?) are nullable; that is, they can be set to null. For 
       *       example, string? is a string that can store null values.
       *    3. The null forgiving operator (!) allows the assignment of a null value to a non-nullable reference
       *       type.
       *       
       * All of these rules are enforced by the compiler.
       */

      [TestMethod]
      public void NullForgivingOperator_Succeeds()
      {
         // Arrange
         #pragma warning disable IDE0059 // Unnecessary assignment of a value
         string notNull = "Hello";
         #pragma warning restore IDE0059 // Unnecessary assignment of a value
         string? nullable = default;

         // Act
         notNull = nullable!;

         // Assert
         Assert.IsNull(notNull);
      }
   }
}
