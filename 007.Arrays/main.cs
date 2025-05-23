using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication95
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user how many fruits they want to enter
            Console.Write("How many fruits do you want to enter? ");
            int count = int.Parse(Console.ReadLine());

            // Declare a string array with the specified size
            string[] fruits = new string[count];

            // Loop to get fruit names from the user and store them in the array
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter fruit #" + (i + 1) + ": ");
                fruits[i] = Console.ReadLine();
            }

            // Print all fruits using a foreach loop
            Console.WriteLine("\nYou entered these fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Show the first fruit, if there is at least one
            if (count > 0)
            {
                Console.WriteLine("\nYour first fruit was: " + fruits[0]);
            }

            // Pause the console so the user can see the output
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

