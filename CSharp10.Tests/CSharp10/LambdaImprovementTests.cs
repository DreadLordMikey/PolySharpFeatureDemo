using System.Linq.Expressions;

namespace PolySharpFeatureTests.CSharp10
{
    [TestClass]
    public class LambdaImprovementTests
    {
        [TestMethod]
        public void Lambda_OfFunc_IsFuncOfStringInt()
        {
            // Arrange
            var parse = (string s) => int.Parse(s);
            var expected = typeof(Func<string, int>);

            // Act
            var actual = parse.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Object_OfFunc_IsFuncOfStringInt()
        {
            // Arrange
            object parse = (string s) => int.Parse(s);
            var expected = typeof(Func<string, int>);

            // Act
            var actual = parse.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delegate_OfFunc_IsFuncOfStringInt()
        {
            // Arrange
            Delegate parse = (string s) => int.Parse(s);
            var expected = typeof(Func<string, int>);

            // Act
            var actual = parse.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LambdaExpression_OfFunc_IsFuncOfStringInt()
        {
            // Arrange
            LambdaExpression parseExpr = (string s) => int.Parse(s); // Expression<Func<string, int>>
            var expected = typeof(Expression<Func<string, int>>);

            // Act
            var actual = parseExpr.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Expression_OfFunc_IsFuncOfStringInt()
        {
            // Arrange
            Expression parseExpr = (string s) => int.Parse(s);       // Expression<Func<string, int>>
            var expected = typeof(Expression<Func<string, int>>);

            // Act
            var actual = parseExpr.GetType();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Lambda_WithReturnType_ReturnsExpectedValue()
        {
            // Arrange
            var choose = object (bool b) => b ? 1 : "two";

            // Act
            var actual = choose(false);

            // Assert
            //Assert.IsInstanceOfType<string>(actual);
            Assert.AreEqual("two", actual);
        }
    }
}
