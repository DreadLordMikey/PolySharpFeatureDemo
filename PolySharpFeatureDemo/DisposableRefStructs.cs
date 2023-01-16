// See: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct#:~:text=You%20can%20define%20a%20disposable%20ref%20struct.%20To%20do%20that%2C%20ensure%20that%20a%20ref%20struct%20fits%20the%20disposable%20pattern.%20That%20is%2C%20it%20has%20an%20instance%20or%20extension%20Dispose%20method%2C%20which%20is%20accessible%2C%20parameterless%20and%20has%20a%20void%20return%20type.

// As of C# 8.0, ref structs can be disposable. They must provide a public Dispose method that returns void and
// takes no parameters. 
//
// Note, however, that ref structs CANNOT implement interfaces. Dispose is supported on ref structs through 
// duck typing.

namespace PolySharpFeatures
{
    // Uncomment the interface implementation below to see how ref structs cannot implement interfaces. This has
    // been true since ref structs were introduced in C# 7.2.

    public ref struct ReferralClaim // : IDisposable
    {
        public int X;
        public int Y;
        private bool isDisposed = false;

        public ReferralClaim (int x, int y)
        {
            this.X = x;
            this.Y = y;
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
            isDisposed = true;
        }
    }
}
