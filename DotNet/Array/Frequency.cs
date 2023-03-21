using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class Frequency
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool isVisited = true;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] == arr[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(arr[i] + " " + count);
                }
               
            }
        }
    }
}


