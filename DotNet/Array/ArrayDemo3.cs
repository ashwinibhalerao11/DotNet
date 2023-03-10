using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    // Display odd numbers from Array
    internal class ArrayDemo3
    {

        static void Odd(int[]n)
        {
            Console.WriteLine("Odd Elements");
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i]%2!=0)
                {
                    Console.WriteLine(n[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());

            int[] n = new int[size];
            Console.WriteLine("Enter Array elements");
            for(int i=0;i<n.Length;i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            ArrayDemo3.Odd(n);
            



        }
    }
}
