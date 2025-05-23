using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication94
{
    class Program
    {
        static void Main(string[] args)
        {
             // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine(); // Read user input as a string
            int number = Convert.ToInt32(input); // Convert input to an integer

            Console.WriteLine("Numbers from 1 to " + number + ":");

            // Initialize counter variable
            int i = 1;

            /*
             * while loop syntax:
             * while (condition)
             * {
             *     // code to repeat
             * }
             *
             * In our case:
             * - condition: i <= number --> loop continues as long as i is less than or equal to number
             */

            while (i <= number)
            {
                // Check if i is even or odd
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even.");
                }
                else
                {
                    Console.WriteLine(i + " is odd.");
                }

                // Increment i by 1
                i++;
            }

            // Wait for the user to press any key before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        
        }
    }
}
