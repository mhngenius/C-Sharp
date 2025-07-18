using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication97
{
    // Define a simple class (blueprint for objects)
    public class Car
    {
        // Fields (variables that belong to the class)
        private string _make;
        private string _model;
        private int _year;

        // Constructor (special method called when creating an object)
        public Car(string make, string model, int year)
        {
            this._make = make;   // 'this' refers to the current object
            this._model = model;
            this._year = year;
        }

        // Method (function that belongs to the class)
        public void DisplayInfo()
        {
            Console.WriteLine("Car: {0} {1} ({2})", _make, _model, _year);
        }

        // Property (special method for accessing fields)
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects (instances of the Car class)
            Car car1 = new Car("Toyota", "Corolla", 2015);
            Car car2 = new Car("Honda", "Civic", 2018);

            // Call methods on the objects
            car1.DisplayInfo();
            car2.DisplayInfo();

            // Access and modify properties
            car1.Make = "Ford";
            Console.WriteLine("Car1's make is now: " + car1.Make);

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}