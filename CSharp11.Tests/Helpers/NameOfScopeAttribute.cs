using System;

namespace CSharp11.Tests.Helpers
{
    public class NameOfScopeAttribute : Attribute
    {
        public NameOfScopeAttribute(string parameterName)
        {
            this.ParameterName = parameterName;
        }

        public string ParameterName { get; set; }
    }
}