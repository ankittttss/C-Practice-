using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enum -: used to store named Constant -: Fixed piece of Information

namespace Oops_Concept
{
    public enum Season { WINTER, SPRING, SUMMER, FALL }

    public static class Maths
    {
        static double PI = 3.14;


        public static double GetRadius(double radius)
        {
            return PI * radius;
            
        }

    }
    internal class StaticKeyword
    {
        //Static -: Whenever we use Static Keyword. That means that we do not have to 
        //Instantiaise -: We do not have to create the object of it;
        // We can create a static class,field and Constructor also
        public static void Main(String[] args) {

            // We have not created an instance here.
            Console.WriteLine(Maths.GetRadius(4));
            Console.WriteLine(Season.WINTER);
         }
    }
}
