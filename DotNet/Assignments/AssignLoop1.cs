using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Assignments
{
    internal class AssignLoop1
    {
        static void Main(string[] args)
        {
            // even numbers between 121 to 229
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Alphabetprg
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            Console.WriteLine("Alphabates from A to Z are: ");
            for (ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.Write(ch + "\t");
            }

        }

    }
    class OddNum
    {
        static void Main(string[] args)
        {
            int num = 521;
            while (num >= 229)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
            num++;
        }
    }
    class LoopQ4

    {
        static void Main(string[] args)
        {
            //sum of 1 t 10
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of 1 to 10: " + sum);
        }
    }
    class LoopQ5
    {
        static void Main(string[] args)
        {
            //sum of even no
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
                Console.WriteLine(sum);
            }
        }
    }
    class LoopQ6
    {
        static void Main(string[] args)
        {
            //sum of odd no
            int sum = 0;
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;

                }
                Console.WriteLine(sum);
            }

        }
    }
    class LoopQ7
    {
        static void Main(string[] args)
        {
            // count digit of no
            int count1 = 0;
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                int remainder = num % 10;
                count1++;
                num = num / 10;

            }
            Console.WriteLine("count of number is " + count1);

        }
    }
    class LoopQ8
    {
        static void Main(string[] args)
        {
            // Power of any digit
            Console.WriteLine("Enter base number");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Exponent");
            int exponent = int.Parse(Console.ReadLine());

            int power = 1;
            int i;
            for (i = 1; i <= exponent; i++)
            {
                power = power * baseNumber;

            }
            Console.WriteLine(power);
        }
    }
    class LoopQ9
    {
        static void Main(string[] args)
        {
            //prime no between 400 to 300
            for (int num = 400; num >= 300; num++)
            {
                bool isprime = true;
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
    class LoopQ10
    {
        static void Main(string[] args)
        {
            // print table of given no
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);

            }

        }
    }
    class LoopQ11
    {
        static void Main(string[] args)
        {

        }
    }
}


