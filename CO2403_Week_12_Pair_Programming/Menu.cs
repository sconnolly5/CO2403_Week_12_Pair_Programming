using System;

namespace CO2403_Week_12_Pair_Programming
{
    /// <summary>
    /// This class is simply a menu to access the different challenges throughout the labsheet.
    /// </summary>
    internal class Menu
    {
        /// <summary>
        /// The current choice that the user has selected
        /// </summary>
        EMenuChoice currentChoice = EMenuChoice.None;

        /// <summary>
        /// This will be called to display the menu to the user
        /// </summary>
        public void Run()
        {
            OutputMenuOptions();
            GetUserChoice();
            LaunchDesiredTask();
        }

        /// <summary>
        /// Output the menu options to the console
        /// </summary>
        private void OutputMenuOptions()
        {
            Console.WriteLine("{0}) Fizzbuzz", (int)EMenuChoice.Fizzbuzz);
            Console.WriteLine("{0}) Fibonacci", (int)EMenuChoice.Fibonacci);
            Console.WriteLine("{0}) Vowel Counter", (int)EMenuChoice.VowelCounter);
        }

        /// <summary>
        /// Get the users desired input from the menu
        /// </summary>
        private void GetUserChoice()
        {
            int userInput;

            // Try to read in an int from what was provided
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                // Validate the value provided by the user
                if (MenuChoiceIsValid(userInput))
                {
                    currentChoice = (EMenuChoice)userInput;
                }
                // If the user didn't provide a valid number in the specified range
                else
                {
                    // Output the error and run the menu again
                    ShowMenuError();
                    // Return at this point to avoid running the menu multiple times 
                    return;
                }
            }
            // If the user didn't provide an int
            else
            {
                // Output the error and run the menu again
                ShowMenuError();
                // Return at this point to avoid running the menu multiple times 
                return;
            }
        }

        /// <summary>
        /// Validate that the menu choice provided is a valid choice
        /// </summary>
        /// <param name="userInput">The number that was input by the user</param>
        /// <returns>True if choice is valid</returns>
        private static bool MenuChoiceIsValid(int userInput)
        {
            return userInput > 0 && userInput < 4;
        }

        /// <summary>
        /// Outputs an error message to the console, and runs the menu again
        /// </summary>
        private void ShowMenuError()
        {
            Console.WriteLine("Invalid choice!");
            Console.ReadKey();
            Run();
        }

        /// <summary>
        /// Launch the worksheet task that the user has selected in the menu
        /// </summary>
        private void LaunchDesiredTask()
        {
            switch (currentChoice)
            {
                case EMenuChoice.Fizzbuzz:
                    var fizzbuzz = new Fizbuzz();
                    fizzbuzz.Run();
                    break;
                case EMenuChoice.Fibonacci:
                    var fibonacci = new Fibonacci();
                    fibonacci.Run();
                    break;
                case EMenuChoice.VowelCounter:
                    var vowelCounter = new VowelCounter();
                    vowelCounter.Run();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
