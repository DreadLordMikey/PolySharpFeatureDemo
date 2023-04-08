using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class AttributesOnLocalFunctionsTests
    {
        [TestMethod]
        public void LocalMethod_WithObsoleteAttribute_GeneratesWarning()
        {
            // Arrange

            [Obsolete("This warning intentionally generated for testing purposes.")]
            static bool IsValidDate(DateTime dt) { return dt > DateTime.MinValue; }

            // Act
            var result = IsValidDate(DateTime.Now);

            // Assert
            Assert.IsTrue(result);
        }
    }
}