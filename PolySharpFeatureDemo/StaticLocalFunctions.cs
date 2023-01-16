// See: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions#local-function-syntax

using System.IO;

namespace PolySharpFeatures
{
    internal class StaticLocalFunctions
    {
        public string GetText(string path, string filename)
        {
            var reader = File.OpenText($"{AppendPathSeparator(path)}{filename}");
            var text = reader.ReadToEnd();
            return text;

            // In versions of C# prior to 8.0, local functions could not be 
            // static. In version 8 and later, local functions can be static.

            static string AppendPathSeparator(string filepath)
            {
                return filepath.EndsWith(@"\") ? filepath : filepath + @"\";
            }
        }
    }
}
