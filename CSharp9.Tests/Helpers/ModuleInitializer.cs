using System.Runtime.CompilerServices;

namespace CSharp9.Tests.Helpers
{
    internal static class ModuleInitializerDemo
    {
        [ModuleInitializer]
        public static void InitializeModule()
        {
            StartupStatus.IsInitialized = true;
        }
    }
}
