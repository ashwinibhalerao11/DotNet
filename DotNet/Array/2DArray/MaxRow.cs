using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array._2DArray
{
    internal class MaxRow
    {
        static void Main(string[] args)
        {
            // Row Wise Max
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the Array elements");
            for(int i=0;i<a.GetLength (0);i++)
            {
                for(int j=0;j<a.GetLength (1);j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength (1);j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            for(int i=0;i<a.GetLength (0);i++)
            {
                int max = a[0,i] ;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (max < a[i,j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine(" max= " + max);
            }
           
        }
    }
    class MaxColumn
    {
        static void Main (string[] args)
        {
            // Column WiseMax
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter the Array elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[j, i])
                    {
                        max = a[j, i];
                    }
                }
                Console.WriteLine(" max= " + max);
            }
        }
    }
}
