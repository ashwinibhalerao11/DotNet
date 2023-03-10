using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    // find max and min element
 
    internal class ArrayDemo5
    {

        public static void MaxMin(int[] arr)
        {
            Console.WriteLine("Array Elements");
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
                


            }
            Console.WriteLine("Max=  " + max);
            Console.WriteLine("Min= " + min);
        }
            static void Main(string[] args)
            {
               int[] arr = new int[5];
               Console.WriteLine("Enter elements in Array");
               for(int i=0;i<arr.Length;i++)
               {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
               }
            ArrayDemo5.MaxMin(arr);

            }
    }
}
