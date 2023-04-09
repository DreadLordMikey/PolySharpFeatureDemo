namespace CSharp10.Tests.Helpers;

public class ImprovedIndefiniteAssignmentImpl
{
    public bool GetDependentValue(out object obj)
    {
        obj = "Foo";
        return true;
    }
}
