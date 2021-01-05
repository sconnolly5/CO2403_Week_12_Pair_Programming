using System;

namespace CO2403_Week_12_Pair_Programming
{
    internal class Fizbuzz
    {
        /// <summary>
        /// The number to count to and check for FizzBuzz.
        /// </summary>
        private const int kMaxFizbuzzCount = 100;

        /// <summary>
        /// Counts through a specified range of numbers, outputs "Fizz" if number divisible by 3, 
        /// outputs "Buzz" if number divisible by 5, outputs "FizzBuzz" if number divisible by both.
        /// </summary>
        public void Run()
        {
            for (int i = 0; i < kMaxFizbuzzCount; i++)
            {
                // Define a string variable so we only output on things that are divisible.
                var outputStr = "";

                // If the number was divisible by 3, add "Fizz" to be output
                if (i % 3 == 0)
                {
                    outputStr += "Fizz";
                }
                
                // If the number was divisible by 5, add "Buzz" to be output
                if (i % 5 == 0)
                {
                    outputStr += "Buzz";
                }

                // If our statement had been initialised with "Fizz", "Buzz", or "FizzBuzz", output it!
                if (outputStr != "")
                {
                    Console.WriteLine("{0}: {1}", i, outputStr);
                }
            }
        }
    }
}
