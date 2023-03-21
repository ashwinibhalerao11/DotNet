using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class ArrayTask
    {
        // create one int type array and replace elements by zero which are divisible by 5

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Array elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());  
            }
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]%5==0)
                {
                    arr[i] = 0;
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
    class MergeArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 7, 8 };
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int k = 0;
            bool isDuplicate;

            // Merge arr1 and arr2 in alternate without duplicates
            for (int i = 0; i < arr1.Length; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    mergedArray[k++] = arr1[i];
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    mergedArray[k++] = arr2[i];
                }
            }

            // Print the merged array
            Console .WriteLine ("Merged Array: ");
            for (int i = 0; i < k; i++)
            {
                Console .WriteLine (mergedArray[i] + " ");
            }
        }
    }

}
