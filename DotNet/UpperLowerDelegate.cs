using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    public delegate string MyDelegate(string str);
    public class Test
    {
        public string Upper(string str)
        {
            Console.WriteLine("Enter string in lowercase");
            str=Console.ReadLine ();
            string str1 = str.ToUpper();
            return str1;
        }
        public string Lower(string str)
        {
            Console.WriteLine("Enter string in uppercase");
            str = Console.ReadLine();
            string str2 = str.ToUpper();
            return str2;
        }

    } 
    public class UpperLowerDelegates
    { 
        static void Main(string[] args)
        {
            Test test = new Test();
            MyDelegate del = new MyDelegate(test.Upper);
            del += new MyDelegate(test.Lower);
            Delegate[] list= del.GetInvocationList();
            foreach(Delegate item in list) 
            {
                Console.WriteLine(item.DynamicInvoke("Ashwini"));
            }
        }
    }
}
