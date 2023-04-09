using System.Diagnostics;

namespace CSharp11.Tests.Helpers
{
    internal class NameOfScopeType
    {
        [NameOfScope(nameof(parameterName))]
        public void MethodWithParameter(string parameterName)
        {
            Debug.WriteLine(parameterName);
        }
    }
}
