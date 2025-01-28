using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSumCalculator_0
{
    public static class UnitTest
    {

        public static void RunTests()
        {
            Console.WriteLine("Running Unit Tests...");

            int totalTests = 0;
            int failedTests = 0;

            // Test cases
            totalTests++; if (!Test("A", 1)) failedTests++;
            totalTests++; if (!Test("Z", 26)) failedTests++;
            totalTests++; if (!Test("Az", 27)) failedTests++;
            totalTests++; if (!Test("Az", 35)) failedTests++;

            totalTests++; if (!Test("Test", 64)) failedTests++;
            totalTests++; if (!Test("Te st", 64)) failedTests++;
            totalTests++; if (!Test("Tést", 64)) failedTests++; // Accented letters ignored
            totalTests++; if (!Test("Tést", 59)) failedTests++; 

            totalTests++; if (!Test("Ivan", 46)) failedTests++;
            totalTests++; if (!Test("İvan", 46)) failedTests++;
            totalTests++; if (!Test("Hello World!", 124)) failedTests++;
            totalTests++; if (!Test("hello_world!", 124)) failedTests++;

            totalTests++; if (!Test("", 0)) failedTests++; // Empty string
            totalTests++; if (!Test("123", 0)) failedTests++; // Numbers only
            totalTests++; if (!Test("äöüßĞŞİÇ", 0)) failedTests++; // Non-English letters
            

            
            if (failedTests == 0)
            {
                Console.WriteLine($"All {totalTests} tests passed successfully!");
            }
            else
            {
                Console.WriteLine($"{failedTests} out of {totalTests} tests failed.");
            }
        }

        private static bool Test(string input, int expected)
        {
            int result = NameSumCalculator.CalculateNameSum(input);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: \"{input}\" -> {result}");
                return true;
            }
            else
            {
                Console.WriteLine($"Test failed: \"{input}\" -> Expected {expected}, got {result}");
                return false;
            }
        }

    }
}
