using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DailyPrograms
{
    internal class Day4
    {
        static void Main(string[] args)
        {

            // date: 10 march
            //Display table of given no
           

            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);

            }
        }
    }
}
