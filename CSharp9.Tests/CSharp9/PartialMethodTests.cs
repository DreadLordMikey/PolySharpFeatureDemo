using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class PartialMethodTests
    {
        [TestMethod]
        public void PartialMethod_WithImplementation_ReturnsExpectedValue()
        {
            // Arrange
            var instance = new GeneratedType();
            var expected = 1;

            // Act
            var actual = instance.GetValue();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public partial class GeneratedType
        {
            public partial int GetValue() { return 1; }
        }

        public partial class GeneratedType
        {
            partial void M();

            public partial int GetValue();            
        }
    }
}
