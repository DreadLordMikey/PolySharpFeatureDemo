namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class LambdaDiscardParameterTests
    {
        [TestMethod]
        public void DiscardParameterInLambda()
        {
            // Arrange
            string Foo(string a, string b, Func<string, string, string> func)
            {
                return func(a, b);
            }

            var expected = "Hello, World!";

            // Act
            var actual = Foo(null, null, (_, _) => "Hello, World!");

            // Assert
            Assert.AreEqual(expected, actual);  
        }
    }
}
