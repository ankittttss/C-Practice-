using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class Generic<T>
    {
        public T id;
       
        public Generic(T id)
        {
            this.id = id;

        }

        public T ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if(value == null)
                {
                    Console.WriteLine("VALUE IS NULL");
                }

                else
                {
                    this.id = value;
                }
            }
        }

        public T getId()
        {
            return (T)this.id;
        }
    }
    internal class Generics
    {
        public static void Main(string[] args) {

            Generic<int> g = new Generic<int>(12);
            Console.WriteLine(g.getId());

            Generic<string> g2 = new Generic<string>("Ankit");
            Console.WriteLine(g2.getId());
        }

    }
}
