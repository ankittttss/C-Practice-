using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class Employees
    {
        int[] age = new int[5];

        public int this[int index]
        {
            get
            {
                return age[index];
            }

            set
            {
                if (index > 0 && age.Length > 0 && value > 0)
                {
                    age[index] = value;
                
                }


                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

    }
    internal class Delegates
    
    {
        public static void Main(String[] args)
        {
            Employees employees = new Employees();
            employees[0] = 1;
            
        }
    }

}
