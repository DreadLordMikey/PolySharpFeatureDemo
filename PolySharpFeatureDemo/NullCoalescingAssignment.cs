namespace PolySharpFeatures
{
    internal class NullCoalescingAssignment
    {
        private static void WithTwoOperands()
        {
            var x = default(string);
            var defaultValue = "foo";

            x ??= defaultValue;
            Debug.WriteLine("NullCoalescingAssignment.WithTwoOperands\n");
            Debug.WriteLine("  var x = default(string);");
            Debug.WriteLine("  var defaultValue = \"foo\";");
            Debug.WriteLine("  x ??= defaultValue;");
            Debug.WriteLine($"  x: {(x == null ? "null" : $"\"{x}\"")}\n");            
        }

        public static void Execute()
        {
            NullCoalescingAssignment.WithTwoOperands();
        }
    }
}
