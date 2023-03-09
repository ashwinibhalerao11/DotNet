using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DailyPrograms
{
    internal class Day2
    {
        static void Main(string[] args)
        {
            //Pattern
            int n = 5;
            for(int i=1;i<=n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write((j%2)+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
