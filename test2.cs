
using System;

namespace MyApp
{
    class Program
    {

        int returnsum(int a,int b){   // These are Functions
             return a + b;
        }

        static void Main(string[] args)
        {
            // Taking Input //
            string? a = Console.ReadLine();
            if (a != null)
            {
                Console.WriteLine(a);
            }

            else
            {
                Console.WriteLine("Null");
            }

            int answer = returnsum(1,2);
            Console.WriteLine(answer);

            char check = 'a';
            Console.WriteLine(check);
        }
    }
}
