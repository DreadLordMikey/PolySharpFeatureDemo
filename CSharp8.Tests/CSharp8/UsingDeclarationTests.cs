using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolySharpFeatureTests.CSharp8
{
    [TestClass]
    public class UsingDeclarationTests
    {
        [TestMethod]
        public void Disposable_WithBlockScope_IsDisposed()
        {
            // Arrange
            var status = new Status();

            // Act
            {
                using Reader reader = new Reader(status);
            }

            // Assert
            Assert.IsTrue(status.Disposed);
        }

        [TestMethod]
        public void Disposable_WithMethodScope_IsDisposed()
        {
            // Arrange
            var status = new Status();

            // Act
            Method(status);

            // Assert
            Assert.IsTrue(status.Disposed);
        }

        private void Method(Status status)
        {
            using var reader = new Reader(status);
            // No implementation is necessary here.
        }

        private class Status
        {
            public bool Disposed { get; set; }
        }

        private class Reader : IDisposable
        {
            public Reader(Status status)
            {
                Status = status;
            }

            public Status Status { get; set; }  

            public void Dispose()
            {
                Status.Disposed = true;
            }
        }

    }
}
