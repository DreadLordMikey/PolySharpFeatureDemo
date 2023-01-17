namespace PolySharpFeatures
{
    internal class IndicesAndRanges
    {
        public void IndexFromEndOperator()
        {
            Debug.WriteLine("IndexFromEndOperator");

            int[] xs = new[] { 0, 10, 20, 30, 40 };
            int last = xs[^1];
            Debug.WriteLine("int[] xs = new[] { 0, 10, 20, 30, 40 };");
            Debug.WriteLine("int last = xs[^1];");
            Debug.WriteLine($"last = {last} (should be 40)\n");  // output: 40

            var lines = new List<string> { "one", "two", "three", "four" };
            string prelast = lines[^2];
            Debug.WriteLine("var lines = new List<string> { \"one\", \"two\", \"three\", \"four\" };");
            Debug.WriteLine("string prelast = lines[^2];");
            Debug.WriteLine($"prelast = {prelast} (should be \"three\")\n");  // output: three
            
            string word = "Twenty";
            Index toFirst = ^word.Length;
            char first = word[toFirst];
            Debug.WriteLine("string word = \"Twenty\";");
            Debug.WriteLine("Index toFirst = ^word.Length;");
            Debug.WriteLine("char first = word[toFirst];");
            Debug.WriteLine($"first = {first} (should be \"T\")");  // output: T

            Debug.WriteLine("");
        }

        public void RangeOperator()
        {
            Debug.WriteLine("RangeOperator");

            Debug.WriteLine("\nThe range operator (..) is not supported for slicing arrays. They can be used to slice");
            Debug.WriteLine("any type that exposes a Count or Length property and a Splice(int, int) method. This also");
            Debug.WriteLine("includes through extension methods.");

            //var numbers = new[] { 0, 10, 20, 30, 40, 50 };
            //Span<int> span = numbers;

            //int start = 1;
            //int amountToTake = 3;
            //var subset = numbers[start..(start + amountToTake)];
            //Display(subset);  // output: 10 20 30

            //int margin = 1;
            //int[] inner = numbers[margin..^margin];
            //Display(inner);  // output: 10 20 30 40

            //string line = "one two three";
            //int amountToTakeFromEnd = 5;
            //Range endIndices = ^amountToTakeFromEnd..^0;
            //string end = line[endIndices];
            //Debug.WriteLine(end);  // output: three

            //void Display<T>(IEnumerable<T> xs) => Debug.WriteLine(string.Join(" ", xs));

            Debug.WriteLine("");
        }

        public static void Execute()
        {
            var sut = new IndicesAndRanges();
            sut.IndexFromEndOperator();
            sut.RangeOperator();
        }
    }
}
