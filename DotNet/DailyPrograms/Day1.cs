using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DailyPrograms
{
    internal class Day1
    {
        static void Main(string[] args)
        {
            // sum of digits
            int n, digit;
            int num, sum=0;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());

            while(n>0)
            {
                digit = n % 10;
                sum = sum + digit;
                n = n / 10;
            }
            Console.WriteLine("Sum of Digits of Number= "+sum);
        }
    }
}
