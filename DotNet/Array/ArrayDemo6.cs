using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class ArrayDemo6
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'v', 'd' };
            for(int i=c.Length-1;i>=0;i--)
            {

                Console.WriteLine(c[i]);
            }
            Console.WriteLine(string.Join(" ",c));
            int j = c.Length - 1;
            for(int i=0;i<c.Length/2;i++)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", c));
        }
    }
}
