using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication98
{
    // Inheritance - Demonstration of inheritance in C#
    // This program shows how a child class inherits from a parent class

    // Base class (or Parent class)
    class Animal
    {
        // Field common to all animals
        public string name;

        // Method that can be used by all animals
        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        // Method that can be used by all animals
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }

    // Derived class (or Child class) that inherits from Animal
    class Dog : Animal
    {
        // Additional method specific to Dog
        public void Bark()
        {
            Console.WriteLine(name + " is barking.");
        }
    }

    // Another derived class that inherits from Animal
    class Cat : Animal
    {
        // Additional method specific to Cat
        public void Meow()
        {
            Console.WriteLine(name + " is meowing.");
        }
    }

    // Main class to run the program
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Dog class
            Dog dog = new Dog();
            dog.name = "Buddy";        // Inherited field
            dog.Eat();                 // Inherited method
            dog.Sleep();               // Inherited method
            dog.Bark();                // Dog's own method

            Console.WriteLine(); // Empty line for readability

            // Create an object of Cat class
            Cat cat = new Cat();
            cat.name = "Whiskers";     // Inherited field
            cat.Eat();                 // Inherited method
            cat.Sleep();               // Inherited method
            cat.Meow();                // Cat's own method

            // Wait for user input before closing
            Console.ReadKey(); // ← Changed from ReadLine() to ReadKey() as requested
        }
    }
}
