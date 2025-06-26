using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication96
{
    class Program
    {
        // This is the entry point of the program
        static void Main(string[] args)
        {
            // Call our custom method and print the result
            int result = AddTwoNumbers(5, 3);
            Console.WriteLine("The result of addition is: " + result);

            // Call a method that returns nothing (void) but prints something
            SayHello("Alice");

            // Wait for the user to press a key before closing the console
            Console.ReadKey(); // Keeps the console window open
        }

        // This method takes two integers and returns their sum
        static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b; // Add the two numbers
            return sum; // Return the result to the caller
        }

        // This method takes a name as input and prints a greeting
        static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "! Welcome to C# tutorials.");
        }
    }
}
