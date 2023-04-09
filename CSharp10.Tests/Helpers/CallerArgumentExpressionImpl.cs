using System.Runtime.CompilerServices;

namespace CSharp10.Tests.Helpers
{
    internal class CallerArgumentExpressionImpl
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public string Execute(bool condition, [CallerArgumentExpression(nameof(condition))] string expression = null)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            return expression;
        }
    }
}
