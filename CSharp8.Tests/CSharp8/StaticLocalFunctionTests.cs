﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class StaticLocalFunctionTests
   {
      [TestMethod]
      public void StaticLocalFunction_WhenCalled_ReturnsExpectedValue()
      {
         // Arrange
         var path = "C:\\Program Files";
         var expected = "C:\\Program Files\\";

         static string AppendPathSeparator(string filepath) => filepath.EndsWith(@"\") ? filepath : filepath + @"\";

         // Act
         var actual = AppendPathSeparator(path);

         // Assert
         Assert.AreEqual(expected, actual);
      }
   }
}
