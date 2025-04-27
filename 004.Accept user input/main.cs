using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication92
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message asking the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read the user's input from the console
            string input = Console.ReadLine();

            // Declare a variable to hold the parsed number
            int number = 0;

            // Try to parse the user's input to an integer
            bool isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                // Check if the number is greater than zero
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else
                {
                    // The number is zero or negative
                    Console.WriteLine("The number is zero or negative.");
                }
            }
            else
            {
                // The user did not enter a valid number
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
