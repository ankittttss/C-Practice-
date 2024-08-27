using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class Temp
    {
        int id;
        string name;
        public Temp(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int getId() { return this.id; }
        public string getName() { return this.name; }

        ~Temp() {
            Console.WriteLine("Destructor Invoked");
          }

    }
    internal class Destructor
    {
        public static void Main(String[] args) {

            Temp temp = new Temp(12, "Ankit");
            Console.WriteLine(temp.getId());
            Console.WriteLine(temp.getName());
            Console.WriteLine(temp);
            Console.ReadLine();
        
        }
    }
}
