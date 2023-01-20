using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PolySharpFeatureTests.Helpers
{
    public static class MethodInfoExtensions
    {
        public static MethodInfo GetLocalMethod(this Type type,
                  string surroundingMethodName, string localMethodName)
        {
            var method = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Static)
             .FirstOrDefault(m => m.GetCustomAttribute<CompilerGeneratedAttribute>() != null
                  && m.IsMatchLocal(surroundingMethodName, localMethodName));

            if (method is not null) return method;

            var nestedTypes = type.GetNestedTypes(BindingFlags.NonPublic)
                               .Where(t => t.GetCustomAttribute<CompilerGeneratedAttribute>() != null);
            foreach (var nested in nestedTypes)
            {
                method = nested.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                   .FirstOrDefault(m => m.IsMatchLocal(surroundingMethodName, localMethodName));

                if (method is not null) return method;
            }

            return null;
        }

        public static bool IsMatchLocal(this MethodInfo localMethod, string surroundingMethodName, string localMethodName)
            => Regex.IsMatch(localMethod.Name, $@"^<{surroundingMethodName}>g__{localMethodName}\|\d+(_\d+)?");
    }
}
