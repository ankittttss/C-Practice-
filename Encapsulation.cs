using System;

namespace Oops_Concept
{
    public class EncapsulationCheck
    {
        // Private fields
        private int age;
        private string name;

        // Constructor to initialize fields
        public EncapsulationCheck(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        // Property for Name with get and set accessors
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        // Property for Age with get and set accessors
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age must be greater than zero.");
                }
                else
                {
                    this.age = value;
                }
            }
        }
    }

    internal class Encapsulation
    {
        public static void Main(string[] args)
        {
            // Creating an instance of EncapsulationCheck
            EncapsulationCheck ec = new EncapsulationCheck(12, "Ankit");

            // Updating the age and name
            ec.Age = 25;    // Property setter for Age
            ec.Name = "Amit";  // Property setter for Name

            // Displaying the values
            Console.WriteLine($"Name: {ec.Name}"); // Property getter for Name
            Console.WriteLine($"Age: {ec.Age}");   // Property getter for Age
        }
    }
}
