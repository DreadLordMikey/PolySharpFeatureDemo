namespace CSharp10.Tests.Helpers;

public class AssignmentAndDeclarationInDeconstructionImpl
{
    public bool Execute(bool returnValue, out string buffer)

    {
        buffer = returnValue ? "Hello, World" : null;
        return returnValue;
    }
}
