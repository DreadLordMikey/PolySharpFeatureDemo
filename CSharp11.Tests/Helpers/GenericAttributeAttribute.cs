namespace CSharp11.Tests.Helpers;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
internal class GenericAttributeAttribute<T> : Attribute
{
    public string Name { get => typeof(T).Name; }
}

