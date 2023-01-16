namespace PolySharpFeatures
{
    internal class GlobalUsingsDemo
    {
        // This compiles because System.Collections.Generic is a global using
        // defined in GlobalUsings.cs.
        private List<int> values = new List<int>();

        public IEnumerable<int> GetOddNumbers()
        {
            // This compiles because System.Linq is defined as a global using
            // in GlobalUsings.cs.
            return values.Where(v => v % 2 != 0);
        }

        public static void Execute()
        {
            var gud = new GlobalUsingsDemo();
            gud.GetOddNumbers();
        }
    }
}
