using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    //find out prime numbersin an array
    internal class ArrayDemo4
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter numbers");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----****----------****---");
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                bool isPrime = true;
                for(int j = 2; j < a[i];j++)
                {
                   if (a[i]%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime == true)
                {
                    sum = sum + a[i];
                }

            }
            Console.WriteLine(sum);
        }
       
    }
}
