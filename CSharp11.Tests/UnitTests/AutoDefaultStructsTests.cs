using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharp11.Tests.Helpers;

namespace CSharp11.Tests.UnitTests
{
    [TestClass]
    public class AutoDefaultStructsTests
    {
        [TestMethod]
        public void AutoDefaultStructMembers_WhenNotInitialized_HaveDefaultValues()
        {
            // Arrange
            var sut = new AutoDefaultStructImpl();

            // Act

            // Assert
            Assert.AreEqual(default, sut.MyString);
            Assert.AreEqual(default, sut.MyInt);
            Assert.AreEqual(default, sut.MyDateTime);
            Assert.AreEqual(default, sut.MyFloat);
        }
    }
}
