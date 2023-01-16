// See: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions#local-function-syntax

using System.IO;

namespace PolySharpFeatures
{
    internal class StaticLocalFunctions
    {
        public string GetFilePath(string path, string filename)
        {
            Debug.WriteLine("StaticLocalFunctions");
            var fixedPath = AppendPathSeparator(path);
            Debug.WriteLine($"AppendPathSeparatorResult: {fixedPath}");
            Debug.WriteLine("");

            return $"{fixedPath}{filename}";

            // In versions of C# prior to 8.0, local functions could not be 
            // static. In version 8 and later, local functions can be static.

            static string AppendPathSeparator(string filepath)
            {
                return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
            }
        }

        public static void Execute()
        {
            var slf = new StaticLocalFunctions();
            slf.GetFilePath("C:\\Dev\\Solutions", "PolySharpFeatureDemo.sln");
        }
    }
}
