using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    public delegate string Delegate(string str);
    public class Tests
    {

        public string Upper(string str)
        {
            Console.WriteLine("string to convert upper");
            str = Console.ReadLine();
            string str1 = str.ToUpper();
            return str1;
        }
        public string Lower(string str)
        {
            Console.WriteLine("string to convert lower");
            str = Console.ReadLine();
            string str2 = str.ToLower();
            return str2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
           Delegate del = new Delegate(test.Upper);
            del += new Delegate(test.Lower);
            Delegate[] list = del.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.DynamicInvoke("Ashwini"));
            }


        }
    }
}
