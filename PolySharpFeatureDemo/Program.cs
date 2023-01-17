namespace PolySharpFeatures
{
    internal class Program
    {
        public static void Main(string[] args)
        {



            Console.ReadLine();
        }

        private static void CSharp8()
        {
            // C# 8.0 Language Features

            AsyncStreams.Execute();
            DisposableRefStruct.Execute();
            GlobalUsingsDemo.Execute();
            IndicesAndRanges.Execute();
            NullCoalescingAssignment.Execute();
            NullableReferenceTypes.Execute();
            PatternMatchingEnhancements.Execute();
            ReadOnlyStruct.Execute();
            StaticLocalFunctions.Execute();
            UnmanagedConstructedTypes.Execute();
        }
    }
}
