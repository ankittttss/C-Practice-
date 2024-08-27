using System;
using MyConsoleApp;

namespace MyApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Roll No");
            string rollNo = Console.ReadLine();

            Console.WriteLine("Enter Your Class");
            string className = Console.ReadLine();

            Console.WriteLine("Enter your Science Marks");
            int scienceMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Maths Marks");
            int mathsMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Chemistry Marks");
            int chemMarks = int.Parse(Console.ReadLine());

            int totalMarks = scienceMarks + mathsMarks + chemMarks;

            Console.WriteLine("Your Total Marks is {0}", totalMarks);

            // Correct percentage calculation
            double percentage = (double)totalMarks / 300;  // Cast totalMarks to double
            Console.WriteLine("Your Percentage is {0:P}", percentage);  // :P format specifier for percentage

            Loop.LoopMain();
            Arrays.ArrayMain();
            // Functions.FuncMain();
            Mainn.DesMain();
            
        }
    }
}
