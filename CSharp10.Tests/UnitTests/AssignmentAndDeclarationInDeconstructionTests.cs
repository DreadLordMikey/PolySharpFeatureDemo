using CSharp10.Tests.Helpers;

namespace CSharp10.Tests.UnitTests
{
    [TestClass]
    public class AssignmentAndDeclarationInDeconstructionTests
    {
        [TestMethod]
        public void Deconstruction_WhenExpectedToBeNull_ReturnsNull()
        {
            // Arrange
            var actual = "";
            var sut = new AssignmentAndDeclarationInDeconstructionImpl();

            // Act
            _ = sut.Execute(false, out actual);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Deconstruction_OnNullReference_DoesNotThrow()
        {
            // Arrange
            AssignmentAndDeclarationInDeconstructionImpl sut = null;
            string actual = null;

            // Act
            _ = sut?.Execute(true, out actual);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Deconstruction_UsingNullCoalescingOperator_DoesNotThrow()
        {
            // Arrange
            AssignmentAndDeclarationInDeconstructionImpl sut = null;
            string actual = null;
            string buffer = "";

            // Act
            if (sut?.Execute(false, out buffer) ?? false)
            {
                actual = buffer.Trim();
            }

            // Assert
            Assert.IsNull(actual);
        }

    }
}
