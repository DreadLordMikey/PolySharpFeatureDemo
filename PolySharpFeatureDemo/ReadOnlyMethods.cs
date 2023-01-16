namespace PolySharpFeatures
{
    // The benefit of the readonly keyword at the property, method, and struct level
    // is that it enforces immutability at compile time. 
    //
    // This eliminates the need to handle runtime exceptions, improving performance
    // and the readability of the code.

    public struct ReadOnlyStruct
    {
        public readonly int X { get; }

        public readonly int Y { get; }

        public ReadOnlyStruct(int x, int y)
        {
            X = x; 
            Y = y;
        }

        public readonly int Sum()
        {
            // This method compiles because it doesn't modify any variables
            // outside of its scope.
            return this.X + this.Y;
        }

        //public void Normalize()
        //{
        //    // This method will not compile because it modifies variables
        //    // outside its scope.

        //    if (Y > X)
        //        return;

        //    var x = this.Y;
        //    this.Y = this.X;
        //    this.X = x;
        //}

        public readonly ReadOnlyStruct Swap()
        {
            if (Y > X)
                return this;

            return new ReadOnlyStruct(Y, X);
        }

        public readonly bool TryCompute(out int area)
        {
            // Compiles because the output variable is considered in-scope,
            // and no other variables outside the method's scope are modified.

            try
            {
                area = X * Y;
                return true;
            }
            catch
            {
                area = 0;   
                return false;
            }
        }

        public static void Execute()
        {
            var x = new ReadOnlyStruct(5, 10);

            Debug.WriteLine($"x.X = {x.X}, x.Y = {x.Y}");
            Debug.WriteLine($"x.Sum: {x.Sum()}");

            var x2 = x.Swap();
            Debug.WriteLine($"x.Swap() = x2.X = {x2.X}, x2.Y = {x2.Y}");

            var succeeded = x.TryCompute(out int result);
            Debug.WriteLine($"x.TryCompute(out int result) = {succeeded}");
            Debug.WriteLine($"result = {result}");
            Debug.WriteLine("");
        }
    }
}
