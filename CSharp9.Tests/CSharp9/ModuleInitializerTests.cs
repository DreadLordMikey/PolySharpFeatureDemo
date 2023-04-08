using CSharp9.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class ModuleInitializerTests
    {
        [TestMethod]
        public void Module_IsInitialized_OnStartup()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(StartupStatus.IsInitialized);
        }
    }
}
