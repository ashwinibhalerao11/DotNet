using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.WeekTests
{
    internal class Test1
    //Que1. 
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;


            for (a = 1; a <= 100; a++)

            {
                if (a % 5 == 0 && a % 10 == 0)
                {
                    Console.WriteLine(a / 5);
                    Console.WriteLine(a / 10);
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine(a / 5);
                }
                else if (a % 10 == 0)
                {
                    Console.WriteLine(a / 10);

                }
                for (a = 1; a <= 100; a++)
                {
                    if (a % 5 == 0 && a % 10 == 0)
                    {
                        Console.WriteLine(a / 5);
                        Console.WriteLine(a / 10);

                    }
                    else if (a % 5 == 0)
                    {
                        Console.WriteLine(a / 5);
                    }
                    else if (a % 10 == 0)
                    {
                        Console.WriteLine(a / 10);

                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
    class Que2
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);

        }
    }
    class Que3
    {
        static void Main(string[] args)
        {
            int i = 1, K = 1;
            while (i++ <= 5)
            {
                K *= i;
            }
            Console.WriteLine("k=" + K + "i=" + i);
        }
    }
    class Que4
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            int product = 1;
            int digit;
            Console.WriteLine("Enter the Number");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                digit = n % 10;
                sum = sum + digit;
                product = product * digit;
                n = n / 10;

            }
            if (sum == product)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not Spy Number");
            }



        }

    }
    class Que5
    {
        static void Main(string[] args)
        {
            bool num = true;
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            while (n != 0)
            {
                if (n % 10 != cube % 10)
                {
                    num = false;
                    break;
                }
                n /= 10;
                cube /= 10;

            }
            if (num)
            {
                Console.WriteLine("Trimorphic Number");
            }
            else
            {
                Console.WriteLine("Not Trimorphic Number");
            }

        }
    }
    class Que6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Que7
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }

    }
    class Que8
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5 - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
    class Que9
    {
        static void Main(string[] args)
        {
            for(int i=5;i>0;i--)
            {
                int mysterInt = 100;
                mysterInt -= i;
                Console.WriteLine(mysterInt);
            }

        }
    }
    class Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            int i = 2;
            bool isPrime = true;


            for(i=2;i<=a/2;i++)
            {
                if(a%i==0)
                {
                    isPrime = false;
                    break;
                }
                if (isPrime && (a - b) == 2)
                {
                    bool isAPrime = true;
                    for( i=2;i<=b/2;i++)
                    {
                        if(b%i==0)
                        {
                            isAPrime = false;
                            break;
                        }
                    }
                    if(isAPrime)
                    {
                        Console.WriteLine(a + "and" + b + "are twin prime");
                    }
                    else
                    {
                        Console.WriteLine(a+"and"+b+"are not twin prime");
                    }
                }
                Console.WriteLine(a+"and"+b+"are not twin prime");
            }
        }
    }
    class Que11
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter number from 1 to 50");
            for(i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine();

                }
            }


        }
    }
    class Que12
    {
        static void Main(string[] args)
        {

        }
    }
    class Que13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                int j = 1;
                while(j<=5)
                {
                    if(j==2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;

                 
                }
                Console.WriteLine(i);
            }

        }
    }
    class Que14
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i=0;i<20;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
    class Que15
    {
        static void Main(string[] args)
        {
            int factorial = 1, sum = 0;
            int n = 0;
            Console.WriteLine("number\t"+"factorial\t"+"sum");
            for(int i=1;i<=5;i++)
            {
                factorial *= i;
                sum += factorial;
                Console.WriteLine(i+"\t" +factorial+ "\t\t"+sum);

            }


        }
    }
}


        


    




                

            
    

