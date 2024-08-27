using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{

    public class OverLoading
    {
        int age;
        string name;

        public OverLoading(int age,string name)
        {
            this.age = age;
            this.name = name;
        }
        
        public int getSum(int a,int b)
        {
            return a + b;
        }

        public int getSum(int a,int b,int c)
        {
            return a + b + c;
        }

        // This is Called Member Over Loading the whole Concept is to 
        // Understand that we use same function but with different Argument



    }
    internal class MemberOverloading
    {
        public static void Main(String[] args)
        {

        }
    }
}
