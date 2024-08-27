using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{

    public class SealedExtent : Sealed
    {
         

        sealed public void show(int a)
        {

        } 

        public void show(int a,int b)
        {

        }
    }
    sealed  internal class Sealed
    {
        // sealed -: we can't override method of sealed class and we cannot derive the method of the
        // sealed class. It will give you error.

        public static void Main(String[] args)
        {
            Console.WriteLine("Sealed Class Functionality");
        }
    }
}
