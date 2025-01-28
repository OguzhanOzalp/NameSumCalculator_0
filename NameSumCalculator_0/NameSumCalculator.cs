using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSumCalculator_0
{
    public static class NameSumCalculator
    {

        public static int CalculateNameSum(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return 0; // Return 0 for null or empty strings
            }


            return name
                .Where(x => IsEnglishLetter(x)) // Filter only English letters
                .Select(x => ToEnglishUpper(x)) // Convert to uppercase for case insensitivity
                .Select(x => x - 'A' + 1)      // Map letters to values (A=1, B=2, ..., Z=26)
                .Sum();                        // Sum all the values
        }

        private static bool IsEnglishLetter(char x)
        {
            return (x >= 'A' && x <= 'Z') || (x >= 'a' && x <= 'z');
        }

        private static char ToEnglishUpper(char x)
        {
            if (x >= 'a' && x <= 'z') // If lowercase English letter
            {
                return (char)(x - 32); // Convert to uppercase using ASCII
            }
            return x; // If already uppercase, return as is
        }

    }
     
}
