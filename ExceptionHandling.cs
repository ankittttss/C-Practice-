using System;

namespace Oops_Concept
{
    // Base class
    public class Poly1
    {
        private string name;
        private int age;

        // Constructor
        public Poly1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display the details
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // Overloading the + operator
        public static Poly1 operator +(Poly1 obj1, Poly1 obj2)
        {
            // Combining the names and summing the ages
            Poly1 obj3 = new Poly1(obj1.name + " " + obj2.name, obj1.age + obj2.age);
            return obj3;
        }

        // Virtual method to demonstrate overriding
        public virtual void Dem()
        {
            
            Console.WriteLine("This is the Dem method in Poly1.");
        }
    }

    // Derived class
    public class Txt : Poly1
    {
        // Constructor for derived class
        public Txt(string name, int age) : base(name, age)
        {
        }

        // Overriding the Dem method
        public override void Dem()
        {
            base.Dem();
            Console.WriteLine("This is the overridden Dem method in Txt.");
        }
    }

    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                // Creating two Poly1 objects
                Poly1 p1 = new Poly1("Ankit", 12);
                Poly1 p2 = new Poly1("Saini", 23);

                // Using the overloaded + operator to combine p1 and p2
                Poly1 p3 = p1 + p2;

                // Displaying the details of the combined object
                p3.Display();

                // Demonstrating polymorphism
                Txt t = new Txt("Example", 30);
                t.Dem(); // Calls the overridden method in Txt
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
