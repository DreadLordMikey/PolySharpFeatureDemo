namespace CSharp11.Tests.Helpers;

internal class FileLocalTypesImplB
{
    public string Name { get => new FileLocalType().Name; }
}

file class FileLocalType
{
    public string Name { get => "FileLocalTypesImplB"; }
}