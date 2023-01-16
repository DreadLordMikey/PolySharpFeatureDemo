#nullable enable

namespace PolySharpFeatures
{
    internal class NullableReferenceTypes
    {

        public void NullForgivenessDemo()
        {
            Debug.WriteLine("NullForgivenessDemo");

            // Because #nullable enable is set at the top of the file, notNull cannot contain a null valaue.
            string notNull = "Hello";      
            Debug.WriteLine($"notNull: {notNull}");

            // string? specifies that a null can be stored in the string variable, nullable.
            string? nullable = default;
            Debug.WriteLine($"nullable: {nullable ?? "null"}");

            // nullable! allows the storage of a null in notNull even though the variable is defined so that
            // it normally could not. This is useful for scenarios where the value of nullable might come
            // from a 3rd party API.
            notNull = nullable!; // null forgiveness
            Debug.WriteLine($"notNull: {notNull ?? "null"}\n");   
        }

        public static void Execute()
        {
            var nrt = new NullableReferenceTypes();
            nrt.NullForgivenessDemo();
        }
    }
}
