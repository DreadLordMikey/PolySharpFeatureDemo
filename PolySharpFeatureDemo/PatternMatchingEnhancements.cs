using System.Security.Cryptography.X509Certificates;

namespace PolySharpFeatures
{
    public class PatternMatchingEnhancements
    {
        public void IsTypeDemo(object greeting)
        {
            Debug.WriteLine("PatternMatchingEnhancements.IsTypeDemo");

            if (greeting is string message)
            {
                Debug.WriteLine(message);
                Debug.WriteLine("");
                return;
            }

            Debug.WriteLine("Not a string greeting.");
            Debug.WriteLine("");
        }

        public void IsTypeInSwitch_ForIntDemo()
        {
            Debug.WriteLine("PatternMatchingEnhancements.IsTypeInSwitch_ForIntDemo");
            var numbers = new int[] { 10, 20, 30 };
            Debug.WriteLine(GetSourceLabel(numbers));
            Debug.WriteLine("");
        }

        public void IsTypeInSwitch_ForCharDemo() 
        {
            Debug.WriteLine("PatternMatchingEnhancements.IsTypeInSwitch_ForCharDemo");
            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            Debug.WriteLine(GetSourceLabel(letters));
            Debug.WriteLine("");
        }

        int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1,
            ICollection<T> collection => 2,
            _ => 3,
        };

        public static void Execute()
        {
            var pme = new PatternMatchingEnhancements();
            pme.IsTypeDemo("Hello, World!");
            pme.IsTypeInSwitch_ForIntDemo();
            pme.IsTypeInSwitch_ForCharDemo();
        }
    }
}
