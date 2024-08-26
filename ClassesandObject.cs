using System;

namespace MyApp
{
    public class Program
    {
        // Data members of the class
        int id;
        string name;
        
        // Method to initialize data members
        public void Initialise(int id, string name)
        {
            this.id = id;         // Correctly assign to the instance variable
            this.name = name;     // Correctly assign to the instance variable
        }

        // Method to display data members
        public void Display()
        {
            Console.WriteLine(id + " " + name); // Correctly display the values
        }

        // Entry point of the program
    }

    public class Testing
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Initialise(12, "Ankit"); // Correctly initialize with parameters
            p.Display(); // Display the values
        }
    }
}
