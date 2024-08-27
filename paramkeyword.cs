using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{


    internal class paramkeyword
    {

        // Paramkeyword -: The Keyword is used to act like spread operator in JS.
        // We will be having variable length container and we don't know the exact size of it

        public void show(params int[] val)
        {
            foreach(int it in val)
            {
                Console.WriteLine(it);
            }
        }
        public static void Main(String[] args)
        {
            paramkeyword p = new paramkeyword();
            p.show(2, 3, 4, 5, 6, 6, 7);

        }
    }
}
