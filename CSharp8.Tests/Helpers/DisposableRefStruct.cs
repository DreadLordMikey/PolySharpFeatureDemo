using System;

namespace PolySharpFeatureTests.Helpers
{
    public ref struct DisposableRefStruct 
    {
        public int X;
        public int Y;
        private bool isDisposed;
        private readonly Action onDispose;

        public DisposableRefStruct(int x, int y, Action onDispose)
        {
            X = x;
            Y = y;
            this.isDisposed = false;
            this.onDispose = onDispose;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (isDisposed || !disposing)
                return;

            // Dispose implementation goes here.
            onDispose?.Invoke();

            isDisposed = true;
        }
    }
}
