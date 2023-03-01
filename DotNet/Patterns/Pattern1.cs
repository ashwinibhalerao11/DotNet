using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Patterns


{
    internal class Pattern1
    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }

        }
    }
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i -= 1)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    class Pattern7
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i, j;
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (i == 2 || j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();

            }
        }
    }
    class Pattern8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column");
            int column = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    if (i == 1 || j == 1 || i == row || j == column)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }



        }
    }
    class Pattern9
    {
        static void Main(string[] args)
        {
            int num = 5;
            int i, j;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" O ");
                    }
                    else
                    {
                        Console.Write(" X  ");
                    }

                }
                Console.WriteLine();

            }
        }
    }
    class Pattern10
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern11
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern12
    {
        static void Main(string[] args)
        {
           for(char i='A';i<='D';i++)
           {
                for(char j='D';j>=i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

           }



        }
    }
    class Pattern13
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >='A' ; i--)
            {
                for (char j = 'A' ; j<= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }


        }
    }
    class Pattern14
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n || i == j)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                                              
                Console.WriteLine();

            }
        }
    }
}

       

