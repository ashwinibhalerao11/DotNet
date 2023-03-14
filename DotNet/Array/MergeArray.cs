using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class MergeArray
    {



        static void Main(string[] args)
        {
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];
            int[] arr3 = new int[8];
            int i, j;
            
            Console.WriteLine("Enter Element of Array1 ");
            for(i=0;i<arr1.Length;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Element of Array2");
            for(i=0;i<arr2.Length;i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for ( i = 0,j=0;i<4;i++)
            {
                arr3[j++] = arr1[i];
            }
            for(i=0;i<4;i++)
            {
                arr3[j++] = arr2[i];
            }
            Console.WriteLine("Elements of Array3");
            for(i=0;i<8;i++)
            {
                Console.WriteLine(arr3[i]);
            }





        }


    }
}
