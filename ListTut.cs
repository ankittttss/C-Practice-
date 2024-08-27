using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    internal class ListTut
    {

        public int rollno;
        public string name;

        public double modulo()
        {
            return Math.Pow(2, 3);
        }

        public void multiply()
        {

        }
        public static void Main(String[] args)
        {
            List<int>list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Remove(1);

            var names = new List<string>() { "Ankit" ,"Saini"};

            for(int i = 0; i <= 10; i++)
            {
                list1.Add(i);
            }

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Question -: Find the Maximum Element in the List 

            int maxx = int.MinValue;

            for(int i = 0; i <= 10; i++)
            {
                if (list1[i] >= maxx)
                {
                    maxx = list1[i];
                }
            }

            Console.WriteLine("The maximum Value is {0}", maxx);
        }
    }
}
