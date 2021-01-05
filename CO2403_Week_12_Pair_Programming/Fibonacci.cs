using System;
using System.Collections.Generic;

namespace CO2403_Week_12_Pair_Programming
{
    /// <summary>
    /// The Fibonacci sequence is the sum of the previous two numbers
    /// </summary>
    internal class Fibonacci
    {
        /// <summary>
        /// This is the number of elements that should be calculated in the fibonacci sequence.
        /// </summary>
        private const int kFibonacciElementsToCountForwards = 10;

        /// <summary>
        /// This is the sequence of numbers that currently exist within the sequence
        /// </summary>
        List<int> sequence = new List<int>();

        public void Run()
        {
            // Get the first number from the user
            Console.WriteLine("Please enter your first number.");
            int firstNum = LoopForUserInput();

            // Get the second number from the user
            Console.WriteLine("Please enter your second number.");
            int secondNum = LoopForUserInput();

            // Empty the list to ensure nothing can pollute the sequence
            sequence.Clear();

            // Add the numbers we have retrieved from the user
            sequence.Add(firstNum);
            sequence.Add(secondNum);

            // Update the sequence based on numbers provided
            InitialiseFibonacciSequence();

            // Output the sequence
            OutputSequence();
        }

        /// <summary>
        /// Loops until the user enters a number.
        /// </summary>
        /// <returns>A valid number the user entered.</returns>
        private int LoopForUserInput()
        {
            int result;
            try
            {
                result = HelperFunctions.ReadInt();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry, please enter a number.");
                result = LoopForUserInput();
            }

            return result;
        }

        /// <summary>
        /// Calculates what the numbers of the fibonacci sequence are based on the details provided
        /// </summary>
        private void InitialiseFibonacciSequence()
        {
            for (int i = 0; i < kFibonacciElementsToCountForwards; i++)
            {
                // Add the two previous elements in the list
                int nextNumInSequence = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];

                // Append the newly calculated number to the list
                sequence.Add(nextNumInSequence);
            }
        }

        /// <summary>
        /// Outputs the Fibonacci sequence variable to the console in a readable format
        /// </summary>
        private void OutputSequence()
        {
            // Output the Fibonacci sequence based on the 
            for (int i = 0; i < sequence.Count; i++)
            {
                Console.Write("{0}", sequence[i]);
                if (i != sequence.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }

    }
}
