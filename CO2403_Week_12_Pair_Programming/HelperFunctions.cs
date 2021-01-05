using System;

namespace CO2403_Week_12_Pair_Programming
{
    internal static class HelperFunctions
    {
        /// <summary>
        /// Reads an integer from the console that has been input by the user. Throws an exception if an invalid input was provided.
        /// </summary>
        /// <returns>The number input by the user.</returns>
        internal static int ReadInt()
        {
            int userInput;

            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                return userInput;
            }
            else
            {
                throw new Exception("Not able to read this number.");
            }
        }

    }
}
