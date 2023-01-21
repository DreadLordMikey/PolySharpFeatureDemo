using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class UnmanagedConstructedTypesTests
   {
      //[TestMethod]
      public void ConstraintWithClass()
      {
      //   Debug.WriteLine("UnmanagedConstructedTypes.ConstraintWithClass\n");

      //   //var instance = new A();
      //   //Foo(instance); // Compile-time error: instance is not non-nullable value type.

      //   Debug.WriteLine("var instance = new A(); // A is a class");
      //   Debug.WriteLine("Foo(instance); // Compile-time error: instance is not non-nullable value type.");

      //   Debug.WriteLine("");
      }

      [TestMethod]
      public void Constraint_OnStruct_ReturnsStruct()
      {
         // Arrange
         var instance = new B();
         var expected = instance;

         // Act
         var actual = Foo(instance); // Works because B is a struct with no reference type members.

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithEnum_ReturnsConstrainedData()
      {
         // Arrange
         var instance = ConsoleColor.Red;
         var expected = instance;

         // Act
         var actual = Foo(ConsoleColor.Red); // Works.

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithDateTime_ReturnsConstrainedData()
      {
         // Arrange
         var expected = DateTime.Now;

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);        
      }

      [TestMethod]
      public void Constraint_WithByte_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(byte);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithShort_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(short);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }


      [TestMethod]
      public void Constraint_WithInt_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(int);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithLong_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(long);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithDecimal_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(decimal);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithFloat_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(float);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Constraint_WithDouble_ReturnsConstrainedData()
      {
         // Arrange
         var expected = default(short);

         // Act
         var actual = Foo(expected);

         // Assert
         Assert.AreEqual(expected, actual);
      }

      private static T Foo<T>(T bar) where T : unmanaged
      {
         return bar;
      }

      private class A
      {
         public int X { get; set; }
         public int Y { get; set; }
      }

      private struct B
      {
         public int X;
         public int Y;

         public B(int x, int y) { X = x; Y = y; }

         public override string ToString()
         {
            return $"X: {X}, Y: {Y}";
         }
      }
   }
}
