namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class TargetTypeConditionalExpressionTests
    {

        [TestMethod]
        public void TypedConditional_WhenResolved_ReturnsExpectedResult()
        {
            // Arrange
            var prefersCats = true;

            // Act
            Pet pet = prefersCats ? new Cat() : new Dog();

            // Assert
            Assert.IsInstanceOfType<Cat>(pet);
        }
        private class Pet { }
        private class Dog : Pet { }
        private class Cat : Pet { }

    }
}
