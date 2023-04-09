using CSharp11.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp11.Tests.UnitTests;

[TestClass]
public class FileLocalTypesTests
{

    [TestMethod]
    public void Given_FileTypeA_ReturnsCorrectLocalFileName()
    {
        // Arrange
        var sut = new FileLocalTypesImplA();

        // Act
        var actual = sut.Name;

        // Assert
        Assert.AreEqual("FileLocalTypesImplA", actual);
    }

    [TestMethod]
    public void Given_FileTypeB_ReturnsCorrectLocalFileName()
    {
        // Arrange
        var sut = new FileLocalTypesImplB();

        // Act
        var actual = sut.Name;

        // Assert
        Assert.AreEqual("FileLocalTypesImplB", actual);
    }
}
