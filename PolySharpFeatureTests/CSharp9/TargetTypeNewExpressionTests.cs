namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class TargetTypeNewExpressionTests
    {
        [TestMethod]
        public void Inititalizer_WithoutDuplicateType_IsInitialized()
        {
            // Arrange

            // Act
            Dictionary<string, List<int>> field = new()
            {
                { "item1", new() { 1, 2, 3} }
            };

            // Assert
            Assert.AreEqual("item1", field.Keys.First());
            Assert.AreEqual(1, field["item1"][0]);
            Assert.AreEqual(2, field["item1"][1]);
            Assert.AreEqual(3, field["item1"][2]);
        }

        [TestMethod]
        public void Initializer_WhenInferred_IsInitialized()
        {
            // Arrange
            string[] Foo(string[] bar) => bar;
            string[] expected = new[] { "foo", "bar", "baz" };

            // Act
            var actual = Foo(new[] { "foo", "bar", "baz" });

            // Assert
            Assert.AreEqual(expected.Count(), actual.Count());
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }
    }
}
