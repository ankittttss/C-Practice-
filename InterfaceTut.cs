using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{

    //{

    // Points to remeber -:
    ////1) It is like abstract class
    //2)It cannot have method body and cannot be instantiated.
    //3)It is used to achieve multiple inheritance which can't be achieved by class.
    //4)
    //}
    public interface Checking
    {
        void draw();
    }

    public class TextChecking : Checking
    {
        public void draw()
        {
            Console.WriteLine("Hi");
        }
    }

    public class VoiceChecking : Checking
    {
        public void draw()
        {
            Console.WriteLine("Hey");
        }
    }
    internal class InterfaceTut
    {

        public static void Main(String[] args)
        {
            VoiceChecking v = new VoiceChecking();
            v.draw();
        }
    }
}
