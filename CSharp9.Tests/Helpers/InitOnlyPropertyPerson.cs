namespace PolySharpFeatureTests.CSharp9
{
    public partial class RecordTypeTests
    {
        record InitOnlyPropertyPerson
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }

            public InitOnlyPropertyPerson(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }
        }

    }
}
