using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class CovariantReturnTypesTests
    {
        [TestMethod]
        public void Type_WithCovariantReturn_ReturnsExpectedValue()
        {
            // Arrange
            C2 c2 = new();
            var expected = "C2.M";

            // Act
            var actual = c2.M();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private interface I1 { object M(); }
        private class C1 : I1 { public object M() { return "C1.M"; } }
        private class C2 : C1, I1 {  public new string M() { return "C2.M"; } }
    }
}
