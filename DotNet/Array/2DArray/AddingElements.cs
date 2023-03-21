using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array._2DArray
{
    internal class AddingElements
    {
        static void Main(string[] args)
        {
            int i, j, n;
            int[,] a = { { 3, 4, 5 }, { 2, 7, 5 }, { 8, 9, 1 } };
            int[,] b = { { 1, 3, 6 }, { 4, 9, 7 }, { 5, 2, 4 } };
            int[,] c = new int[3, 3];
            n = 3;
            int x = a.GetUpperBound(0);
            int y = b.GetUpperBound(1);

            for (i = 0; i <= x; i++)
            {
                for (j = 0; j <= y; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**********");
            for (i = 0; i <= x; i++)
            {
                for (j = 0; j <= y; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition");
            for (i = 0; i <= x; i++)
            {
                for (j = 0; j <= y; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (i = 0; i <= x; i++)
            {
                for (j = 0; j <= y; j++)
                {
                    Console.Write(c[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
    


    

