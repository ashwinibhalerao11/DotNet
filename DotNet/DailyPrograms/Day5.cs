using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DailyPrograms
{
    internal class Day5
    {
        // Duck Number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            
            if(Duck(num))
            {
                Console.WriteLine("Duck"); 
            }
            else
            {
                Console.WriteLine("Not Duck");
            }

        }
        public static bool Duck(int num)
        {
            while(num!=0)
            {
                int rem = num % 10;
                if(rem==0)
                {
                    return true;
                }
                num = num / 10;

            }
            return false;
        }
    }
}
