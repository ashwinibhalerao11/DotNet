using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Assignments
{
    internal class FundaAssign
    {
        static void Main(string[] args)
        {
            // Area of an equilateral triangle
            int side;
            float area;
            Console.WriteLine("Enter the length of side");
            side = Convert.ToInt32(Console.ReadLine());
            area = (float)(Math.Sqrt(3) * (side * side)) / 4;
            Console.WriteLine("Area of Equilateral Triangle: " + area);



        }
    }
    class AssignQ2
    {
        static void Main(string[] args)
        {
            // Percentage of five sub and its average
            Console.WriteLine();
            Console.WriteLine("percentage of five subjects");

            Console.WriteLine("enter marks of marathi");
            int marathi = int.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of hindi");
            int hindi = int.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of english");
            int english = int.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of maths");
            int maths = int.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of science");
            int science = int.Parse(Console.ReadLine());

            int total = marathi + hindi + english + maths + science;

            double percentage = total / 500.0 * 100;

            Console.WriteLine("Percentage of five sub" + percentage);
        }
    }
    class AssignQ3
    {
        static void Main(string[] args)
        {
            // ENter P;T;R and calculate compound intrest
            double Amount;
            double CI;

            Console.WriteLine("Coumpound Intrest");
            Console.WriteLine("Enter Principal Intrest");// Initial Amount
            int P = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year");//no of time period
            int T = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the intrest rate");
            int R = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Compound period");// no of time intrest per time period
            int n = int.Parse(Console.ReadLine());

            Amount = P * Math.Pow((1 + R / (100 * n)), n * T);
            //CI = Amount - P;
            Console.WriteLine("Compound Intrest= " + (Amount, 2));



        }
    }
    class AssignQ4
    {
        static void Main(string[] args)
        {
            // temp in celcius and covert in fahrenheit
            Console.WriteLine("Enter temp in celcius");
            float c = float.Parse(Console.ReadLine());
            float f = (float)((1.8 * c) + 32.0);
            Console.WriteLine("Temp in Fahrenheit= " + f);
        }
    }
    class AssignQ5
    {
        static void Main(string[] args)
        {
            // Frenheit to celcius
            Console.WriteLine("Enter temp in Farenheit");
            float f = float.Parse(Console.ReadLine());
            float c = (float)((f - 32) / 1.8);
            Console.WriteLine("Temp in elcius= " + c);

        }
    }
    class AssignQ6
    {
        static void Main(string[] args)
        {
            // leap year or not
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
        }
    }
    class AssignQ7
    {
        static void Main(string[] args)
        {
            // no is divisible by 5 and 11 or not
            Console.WriteLine("Enter number");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 5 == 0)
            {
                Console.WriteLine("divisible by 5 ");
            }
            else if (n1 % 11 == 0)
            {
                Console.WriteLine("divible by 11 ");
            }
            else
            {
                Console.WriteLine("not divisible by 5 and 11");

            }
        }
    }
    class AssignQ8
    {
        static void Main(string[] args)
        {
            // maximum no between three no
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine("Num1 is Maximum");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Num2 is Maximum");
            }
            else
            {
                Console.WriteLine("Num3 is maximum");
            }

        }
    }
    class AssignQ9
    {
        static void Main(string[] args)
        {
            //char is vowel or consonant
            Console.WriteLine("Enter character");
            char cha = Convert.ToChar(Console.ReadLine());
            string res = (cha == 'a' || cha == 'e' || cha == 'i' || cha == 'o' || cha == 'u') ? " Vowel" : " Consonant";
            Console.WriteLine("char is " + res);

        }
    }
    class AssignQ10
    {
        static void Main(string[] args)
        {
            // Create Calculator
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("+ Addition \n - Substraction \n * Multiplication \n / Division ");
            Console.WriteLine("Enter operator from Above");
            char result = Convert.ToChar(Console.ReadLine());


            switch (result)
            {
                case '+':
                    Console.WriteLine("Addition= " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Subtraction= " + (num1 * num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication= " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division= " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("You Enter Invalid operation");
                    break;

            }
            Console.WriteLine(result);
        }

    }
    class AssignQ11
    {
        static void Main(string[] args)
        {
            // positive negative or zero
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("zero");
            }            
        }
    }
    class AssignQ12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter charactor");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("is digit");
            }
            else
            {
                Console.WriteLine("is special char");
            }
        }
    }
    class AssignQ13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
             
            if(num%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");

            }
        }
    }
    class AssignQ14
    {
        static void Main(string[] args)
        {
            // no of days in a month
            Console.WriteLine("Enter month from 1 to 12");
            int month = Convert.ToInt32(Console.ReadLine());

        }
    }
}




        
            
        

   

