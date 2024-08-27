using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    internal class Hashset
    {

        public static void Main(String[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);

            foreach(int it in set)
            {
                Console.WriteLine(it);
            }

            for(int i = 1; i <= 10; i++)
            {
                set.Add(i);
            }

            set.Remove(0);

            // Stores Unique Value -> Similar to Multiset in c++
            // SortedSet -; Same as Hashset but stores in Ascending Order 

            SortedSet<int>set2 = new SortedSet<int>();
            set2.Add(98);
            set2.Add(55);

            foreach(int it in set2)
            {
                Console.WriteLine(it);
            }
        }
    }
}
