using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.loop
{
    internal class PrimeNumbers
    {
        static void Main(string[] args)
        {
           for(int num=1;num<=5;num++)
           {
                bool isprime = true;
                for(int i=2;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime==true)
                {
                    Console.WriteLine(num);
                }
           }
        }
    }
}
