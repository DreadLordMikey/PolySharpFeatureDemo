// There are two ways to enable nullable reference types:
//
// A. Add <nullable>enable</nullable> into the first <PropertyGroup/> in your project file
//   -- OR --
// B. Add #nullable enable at the top of each file where you want to enable the functionality.
// 
// Option A enables the feature throughout the solution. You can disable it in specific files by adding #nullable disable
// at the top of the file.
//
// Option B enables the feature *only* in the specific files that it is added to. This option is most useful for legacy
// code, as it permits a gradual migration of the codebase to use the new functionality.

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

        public void NullableReferenceTypeDemo()
        {
            string shortDescription = default; // Warning! non-nullable set to null;
            var product = new ProductDescription(shortDescription); // Warning! static analysis knows shortDescription maybe null.

            string description = "widget";
            var item = new ProductDescription(description);

            item.SetDescriptions(description, "These widgets will do everything.");
        }

        public static void Execute()
        {
            var nrt = new NullableReferenceTypes();
            nrt.NullForgivenessDemo();
            nrt.NullableReferenceTypeDemo();
        }
    }

    public class ProductDescription
    {
        private string shortDescription;            // Not nullable
        private string? detailedDescription;        // Nullable

        public ProductDescription() // Warning! shortDescription not initialized.
        {
        }

        public ProductDescription(string productDescription) =>
            this.shortDescription = productDescription;

        public void SetDescriptions(string productDescription, string? details = null)
        {
            shortDescription = productDescription;
            detailedDescription = details;
        }

        public string GetDescription()
        {
            if (detailedDescription.Length == 0) // Warning! dereference possible null
            {
                return shortDescription;
            }
            else
            {
                return $"{shortDescription}\n{detailedDescription}";
            }
        }

        public string FullDescription()
        {
            if (detailedDescription == null)
            {
                return shortDescription;
            }
            else if (detailedDescription.Length > 0) // OK, detailedDescription can't be null.
            {
                return $"{shortDescription}\n{detailedDescription}";
            }
            return shortDescription;
        }
    }
}
