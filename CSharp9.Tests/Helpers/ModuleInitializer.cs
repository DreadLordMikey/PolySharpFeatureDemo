using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PolySharpFeatureTests.CSharp9
{
    internal sealed class ModuleInitializerDemo
    {
        [ModuleInitializer]
        public static void InitializeModule()
        {
            Debug.WriteLine("This code is invoked before any other code in the assembly.");
        }

        private ModuleInitializerDemo() { }
    }
}
