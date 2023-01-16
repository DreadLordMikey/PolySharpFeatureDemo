using System;
using System.Collections.Generic;

namespace PolySharpFeatures
{
    public class PatternMatchingEnhancements
    {
        public string IsType(object greeting)
        {
            if (greeting is string message)
            {
                return message.ToLower();
            }

            return null;
        }

        public int IsTypeInSwitch_ForInt()
        {
            var numbers = new int[] { 10, 20, 30 };
            return GetSourceLabel(numbers);  // output: 1
        }

        public int IsTypeInSwitch_ForChar() 
        { 
            var letters = new List<char> { 'a', 'b', 'c', 'd' };
            return GetSourceLabel(letters);  // output: 2
        }

        int GetSourceLabel<T>(IEnumerable<T> source) => source switch
        {
            Array array => 1,
            ICollection<T> collection => 2,
            _ => 3,
        };

    }
}
