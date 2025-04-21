using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication91
{
    class Program
    {
        static void Main(string[] args)
        {
             // We create a number variable and assign it a value
        int number = -5;

        // What is 'if' and 'else'?
        // The 'if' statement checks if a condition is true.
        // If it's true, the code inside the 'if' block will run.
        //
        // The 'else' (and 'else if') blocks are used to handle other situations.
        // 'else if' checks for a different condition if the first one was false.
        // 'else' runs when none of the above conditions are true.

        if (number > 0)
        {
            // This block runs if the number is greater than 0
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            // This block runs if the number is less than 0
            Console.WriteLine("The number is negative.");
        }
        else
        {
            // This block runs if the number is neither greater nor less than 0
            // In other words, it's exactly zero
            Console.WriteLine("The number is zero.");
        }
    }
}
