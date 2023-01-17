namespace PolySharpFeatureTests.Helpers
{
   public ref struct DisposableRefStruct // : IDisposable
   {
      public int X;
      public int Y;
      private bool isDisposed = false;
      private Action onDispose = null;

      public DisposableRefStruct(int x, int y, Action onDispose)
      {
         X = x;
         Y = y;
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
         if (onDispose != null) onDispose();

         isDisposed = true;
      }
   }
}
