using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array._2DArray
{
    internal class SumOfRow
    { 
        static void Main(string[] args)
        {
            int[,] a= { {3,4,5 }, {5,2,6 }, {7,9,3 } };
            int sum ;
            for(int i=0;i<a.GetLength(0);i++)
            {
                sum = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    sum =sum +a[i, j];
                    Console.Write(a[i,j]+" ");

                }
                Console.Write("  sum: "+sum);
                Console.WriteLine();
            }

        }
    }
    class SumOfColumns
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 4, 5 }, { 5, 2, 6 }, { 7, 9, 3 } };
            int sum;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j,i];
                    Console.Write(a[j, i] + " ");

                }
                Console.Write(" Column sum: " + sum);
                Console.WriteLine();
            }

        }
    }
    
}
