using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    // DELEGATE DEMO WITH MULTI CAST

    public delegate int MyDelegate3(int x, int y);
    public class Cal
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
    public class WithMultiCast
    {
        static void Main(string[] args)
        {
            Cal cal = new Cal();
            MyDelegate2 del = new MyDelegate2(cal.Add);//added method refference
            del += new MyDelegate2(cal.Sub);
            del += new MyDelegate2(cal.Mul);

            //invokation list

            Delegate[] list = del.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(25, 20));
            }
        }
    }
}

