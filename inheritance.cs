using System;

namespace Oops_Concept
{
    // This is the example of Single Level Inheritance (Man -> Father)
    public class Man
    {
        protected string name; // Made protected to allow access in derived class
        protected string dob;  // Made protected to allow access in derived class

        public Man(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        // Marking the method as virtual to allow overriding in derived classes
        public virtual void Showing_The_Role()
        {
            Console.WriteLine("I am a Man");
        }
    }

    public class Father : Man
    {
        public Father(string name, string dob) : base(name, dob)
        {
        }

        // Correctly overriding the base class method
        public override void Showing_The_Role()
        {
            Console.WriteLine("I am a Father");
        }
    }

    internal class Programm
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Father class
            Father f = new Father("Saini", "1233");

            // Calling the overridden method
            f.Showing_The_Role();  // Output: I am a Father
        }
    }
}
