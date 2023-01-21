using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolySharpFeatureTests.Helpers;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;


namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class LocalFunctionAttributeTests
    {
        [TestMethod]
        public void Attribute_OnLocalMethod_IsDiscoverable()
        {
            // Arrange

            #pragma warning disable CS8321 
            [Obsolete("For testing purposes.")]static void Foo() { throw new NotImplementedException(); }
            #pragma warning restore CS8321 

            var type = typeof(LocalFunctionAttributeTests);
            var methodName = MethodBase.GetCurrentMethod().Name;
            var localMethodName = "Foo";
            var methodInfo = type.GetLocalMethod(methodName, localMethodName);

            // Act
            var attribute = methodInfo.GetCustomAttribute<ObsoleteAttribute>();

            // Assert
            Assert.IsNotNull(attribute);
            Assert.IsInstanceOfType<ObsoleteAttribute>(attribute);
        }

        [TestMethod]
        public void LocalMethod_WithExternModifier_IsInvocable()
        {
            // Arrange
            [DllImport("kernel32", SetLastError = true)]
            static extern int GetCurrentDirectory(int bufSize, StringBuilder buf);
            var directoryBuffer = new StringBuilder(2048);
            var bytesWritten = 0;

            // Act
            bytesWritten = GetCurrentDirectory(2048, directoryBuffer);


            // Assert
            Assert.IsTrue(bytesWritten > 0);
            Assert.IsTrue(directoryBuffer.ToString().Length > 0);
        }

    }
}
