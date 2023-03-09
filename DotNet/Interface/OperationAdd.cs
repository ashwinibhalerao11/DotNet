using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Interface
{
    abstract class Addition
    {
        public int a;
    }
    internal interface INable
    {
        static int b;
    }
    internal class Calculation :  Addition,INable
    {
        public void Display(int res)
        {
            Console.WriteLine("Addition: " + res);
        }
    }
    internal class OperationAdd
    {
        static void Main(string[] args)
        {
            Result res = new Result();
            Console.WriteLine("Enter the value of A ");
            res.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B: ");
            INumable.b = int.Parse(Console.ReadLine());
            int c = res.a + INumable.b;
            res.Display(c);
        }
    }
}
