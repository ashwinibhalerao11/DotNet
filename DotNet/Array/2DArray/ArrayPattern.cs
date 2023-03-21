using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array._2DArray
{
    internal class ArrayPattern
    {
        // Pattern 1
        static void Main(string[] args)
        {
            int[,] arr = { {2,3,5,7 },{7,6,1,2},{9,8,4,3},{5,4,7,8 } };
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength (1);j++)
                {
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("+ ++ ++ ++ +++++++++ ++ ++ ++ +");
            Console.WriteLine(" ");

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength (1);j++)
                {
                    if (j == 0 || i == j || j == arr.GetLength(1) - 1)
                    {
                        Console.Write(arr[i, j] +" ");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
        } 
    }
    class Pattern2
    {
        static void Main(string[]args)
        {

        }
    }
}
