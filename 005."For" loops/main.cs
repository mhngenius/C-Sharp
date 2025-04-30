using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication93
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine(); // Read user input as a string
            int number = Convert.ToInt32(input); // Convert the string to an integer

            Console.WriteLine("Numbers from 1 to " + number + ":");

            /*
             * for loop syntax:
             * for (initialization; condition; update)
             * {
             *     // code to repeat
             * }
             *
             * In our case:
             * - initialization: int i = 1 --> we start counting from 1
             * - condition: i <= number --> loop continues as long as i is less than or equal to the user's number
             * - update: i++ --> after each loop, increase i by 1
             */

            for (int i = 1; i <= number; i++)
            {
                // Check if the number is even or odd using the modulus operator %
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even.");
                }
                else
                {
                    Console.WriteLine(i + " is odd.");
                }
            }

            // Wait for the user to press any key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
