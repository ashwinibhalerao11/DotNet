using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class ArrayDemo2
    {
        // sum of array elements
        static void Sum(int[]a)
        {
            Console.WriteLine("Sum of an Array Elements....");
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum = sum+a[i];
            }
            Console.WriteLine(sum);

        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("Enter the Array Elements");

            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArrayDemo2.Sum(a);

        }
        
    }
  

    
}
