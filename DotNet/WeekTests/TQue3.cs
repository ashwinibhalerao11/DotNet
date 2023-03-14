using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.WeekTests
{
    class Mobile
    {
        // Q3 Multilevel Inheritance
        protected string Memory = "128 GB";
    }
    class Samsung : Mobile
    {
        protected string Camera = "64 Pixel";
    }
    class S22 : Samsung
    {
        string Colour = "White";

        public void ShowS22()
        {
            Console.WriteLine("\nMemory: " + Memory + "\nCamera: " + Camera + "\nColour: " + Colour);
        }
    }
    internal class TQue3
    {
        static void Main(string[] args)
        {
            S22 S = new S22();
            S.ShowS22();
        }
    }
}
