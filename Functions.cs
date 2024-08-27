using System;

namespace MyApp
{
    public class Functions
    {
        public int ReturnSum(int a, int b)
        {
            return a + b;
        
        }

public static void ReturnNothing()
{
    Console.WriteLine("hi");
}

public static void FuncMain()
{
    // Create an instance of the Functions class
    Functions functions = new Functions();

    // Call the non-static method using the instance
    int ans = functions.ReturnSum(1, 2);
    Console.WriteLine(ans);

    // The Major Difference with the static function is that it needs to be called up by the class
    // But with the non-static function is that it needs to be called with the object

    Functions.ReturnNothing();

    // There are two types of functions -: Parametrised , Non-Paramerised


       
}
    }
}
