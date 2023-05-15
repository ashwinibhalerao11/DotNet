using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    // DELEGATE DEMO WITH SINGLE CAST


    public delegate int MyDelegate2(int x, int y);//define delegate,signature should match with the method signature
    public class Calc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class WithSingleCast
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            MyDelegate2 del = new MyDelegate2(calc.Add);//added method refference
            Console.WriteLine(del.Invoke(10, 20));//call using invoke method 
        }
    }
}
