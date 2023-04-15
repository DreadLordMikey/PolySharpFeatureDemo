namespace CSharp11.Tests.Helpers;

[GenericAttribute<GenericAttributeMethodImpl>]
internal class GenericAttributeMethodImpl
{
    [GenericAttribute<string>]
    public string Execute()
    {
        return "Hello, World!";
    }
}
