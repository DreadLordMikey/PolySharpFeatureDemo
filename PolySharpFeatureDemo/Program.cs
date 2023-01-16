namespace PolySharpFeatures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DisposableRefStruct.Execute();
            GlobalUsingsDemo.Execute();
            NullableReferenceTypes.Execute();
            PatternMatchingEnhancements.Execute();            
            ReadOnlyStruct.Execute();
            StaticLocalFunctions.Execute();

            Console.ReadLine();
        }
    }
}
