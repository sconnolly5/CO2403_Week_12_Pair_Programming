using System;
using System.Collections.Generic;

namespace CO2403_Week_12_Pair_Programming
{
    internal class VowelCounter
    {
        List<char> vowels = new List<char>(new char[]{'a', 'e', 'i', 'o', 'u'});

        internal void Run()
        {
            // Request input string from user
            Console.WriteLine("Please provide an input. ");
            string input = Console.ReadLine();

            // Calculate the number of vowels in the string
            int vowelCount = CalculateNumVowels(input);

            // Output the number of vowels that were calculated
            Console.WriteLine("Your string contains {0} vowels", vowelCount);
        }

        /// <summary>
        /// Looks at each character in a string to determine the number of vowels in it
        /// </summary>
        /// <param name="input">The string input by the user</param>
        /// <returns>The number of vowels present in the string</returns>
        private int CalculateNumVowels(string input)
        {
            int vowelCount = 0;

            // Iterate over each character
            foreach (char c in input)
            {
                // Check if our list of vowels contains this character
                if (vowels.Contains(c))
                {
                    // It did! Increment the count.
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
