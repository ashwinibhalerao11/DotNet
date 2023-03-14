using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class SortChar
    {
        public static void SortCharArray(char[] c)
        {
            Console.WriteLine(string.Join(" ", c));
            for(int i=0;i<c.Length;i++)
            {
                for(int j=i+1;j<c.Length;j++)
                {
                    if (c[i] < c[j])
                    {
                        char temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'j', 'g', 'r', 's' };
            SortChar.SortCharArray(ch);
            Console.WriteLine(string.Join(" ",ch));
        }
    }
}
