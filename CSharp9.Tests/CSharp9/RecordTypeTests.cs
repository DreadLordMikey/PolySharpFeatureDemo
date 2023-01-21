using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public partial class RecordTypeTests
    {
        [TestMethod]
        public void Record_WithPositionalParameters_CanBeQueried()
        {
            // Arrange
            var person = new PositionalPerson("John", "Doe");
            var expected = "PositionalPerson { FirstName = John, LastName = Doe }";

            // Act
            var actual = person.ToString();

            // Assert
            Assert.AreEqual("John", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Record_WithStandardProperties_CanBeQueried()
        {
            // Arrange
            var person = new PropertyPerson();
            var expected = "PropertyPerson { FirstName = John, LastName = Doe }";

            // Act
            person.FirstName = "John";
            person.LastName = "Doe";

            var actual = person.ToString();

            // Assert
            Assert.AreEqual("John", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Record_WithInitOnlyProperties_CanBeQueried()
        {
            // Arrange
            var person = new InitOnlyPropertyPerson("John", "Doe");
            var expected = "InitOnlyPropertyPerson { FirstName = John, LastName = Doe }";

            // Act
            var actual = person.ToString();

            // Assert
            Assert.AreEqual("John", person.FirstName);
            Assert.AreEqual("Doe", person.LastName);
            Assert.AreEqual(expected, actual);
        }

    }
}
