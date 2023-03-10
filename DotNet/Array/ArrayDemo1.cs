using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class ArrayDemo1
    {
        // character type of array
        static void Main(string[] args)
        {
            char[] ch = new char[4];
            Console.WriteLine("Enter Array Element");

            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("**************");

            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine("***************");
            foreach(char x in ch)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("****************");
            Console. WriteLine(string.Join(' ',ch));


        }
    }
}
