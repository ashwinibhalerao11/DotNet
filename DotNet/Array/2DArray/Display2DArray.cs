using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array._2DArray
{
    internal class Display2DArray
    {
        static void Main(string[] args)
        {
            // methods to write 2d array
            /* 1. 
              int[,] arr = { {2,7,8 },
                                 {3,5,6 },
                                 {1,2,3 } };*/



            /* 2.
              int[,] a = new int[3, 3];
            a[0, 0] = 1;
            a[0, 1] = 4;
            a[0, 2] = 3;
            a[1, 0] = 7;
            a[1, 1] = 5;
            a[1, 2] = 8;
            a[2, 0] = 5;
            a[2, 1] = 4;
            a[2, 2] = 7;*/


            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the elements of array");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("*****************");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

                        

        



    





