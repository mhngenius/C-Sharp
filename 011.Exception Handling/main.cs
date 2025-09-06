using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication99
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");

            try
            {
                // Try to read input and convert it to an integer
                int number = Convert.ToInt32(Console.ReadLine());

                // If successful, print the number
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                // This block runs if the input was not a number (like "abc")
                Console.WriteLine("Error: That was not a valid number!");
            }
            finally
            {
                // This block always runs (whether there was an error or not)
                Console.WriteLine("Program finished!");
            }
        }
    }
}
