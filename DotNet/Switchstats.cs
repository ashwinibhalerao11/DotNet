using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal class Switchstats
    {
        static void Main(string[] args)
        {
            // enter no 1 to 5 in word

            Console.WriteLine("Enter the number between 1 to 5");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;


            }
        }

        class vowelconso
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Charactor");
                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("vowel");
                        break;
                    case 'e':
                        Console.WriteLine("vowel");
                        break;
                    case 'i':
                        Console.WriteLine("vowel");
                        break;
                    case 'o':
                        Console.WriteLine("vowel");
                        break;
                    case 'u':
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("Consonant");
                        break;

                }

            }
        }
        class areas
        {
            static void Main(string[] args)
            {
                int l, b, s, h, b1;
                double r;
                int num1;
                Console.WriteLine("Area");
                Console.WriteLine("1.Area of Circle \n 2.Area of Square \n 3.Area of Rectangle \n 4.Area of Triangle");
                Console.WriteLine("Enter the number to do calculations");
                num1 = int.Parse(Console.ReadLine());

                switch (num1)

                {
                    case 1:
                        Console.WriteLine("Enter thr radius: ");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Circle: " + (3.14 * r * r));
                        break;
                    case 2:
                        Console.WriteLine("Enter the value of side");
                        s = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Square: " + (s * s));
                        break;
                    case 3:
                        Console.WriteLine("Enter l and b: ");
                        l = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter l and b: " + (l * b));
                        break;
                    case 4:
                        Console.WriteLine("Enter the value of h and b1: ");
                        h = int.Parse(Console.ReadLine());
                        b1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of Triangle: " + (h * b1) / 2);
                        break;
                    default:
                        Console.WriteLine("You Entered Invalid data");
                        break;

                }







            }

        }
        class oddevenswitch
        {
            static void Main(string[] args)
            {
               int num2;
                Console.WriteLine("Enter the Number");
                num2 = int.Parse(Console.ReadLine());
                switch (num2 % 2 == 0)
                {
                    case true:
                        Console.WriteLine("Number is even");
                        break;
                    case false:
                        Console.WriteLine("Number is odd");
                        break;
                }








            }

        }
    }
}
















            





        
      
           

        

    

