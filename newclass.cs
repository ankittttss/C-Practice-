using System;
namespace MyApp
{
    public class NewClass
    {
        public static void AdMain()
        {
            Console.WriteLine("Hello from NewClass!");

            // Arithemetic Operators;
            int no1 = 10;
            int no2 = 20;

            int ans1 = no1+no2;
            ans1 = no1-no2;
            ans1 = no1*no2;
            ans1 = no1/no2;
            ans1 = no1%no2;

            //Relational Operators 
            int no3 = 40;
            int no4 = 50;

            if(no3>=4){
                Console.WriteLine("hi");
            }

            else {
                Console.WriteLine("hey");
            }

            // Conditional Operators -: AND(&&) OR(||) Not(!);
            // In And every condition needs to be true to exectute that Block

        }
    }
}