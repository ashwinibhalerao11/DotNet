using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DotNet.Assignments
{
    internal class Assign1
    {
        static void Main(string[] args)
        {
            //Create calculator 
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
                case '+': Console.WriteLine("Addition= " + (num1 + num2));
                    break;
                case '-': Console.WriteLine("Subtraction= " + (num1 * num2));
                    break;
                case '*': Console.WriteLine("Multiplication= " + (num1 * num2));
                    break;
                case '/': Console.WriteLine("Division= " + (num1 / num2));
                    break;
                default: Console.WriteLine("You Enter Invalid operation");
                    break;

            }
            Console.WriteLine(result);
        }
        



        class VowelConso
        {
            static void Main(string[] args)
            {
                // vowel and consonant
                Console.WriteLine("Enter Character");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    Console.WriteLine("Vowel");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
            }

        }
        class Ternerop
        {
            static void Main(string[] args)
            {
                // maximum no between no ternery operator

                Console.WriteLine("Enter the no1");
                int no1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the no2");
                int no2 = int.Parse(Console.ReadLine());
                int max = no1 > no2 ? no1 : no2;
                Console.WriteLine(max);

                string ans = no1 > no2 ? "no1 is gr" : "no2 is gr";
                Console.WriteLine(ans);


                // Vowel consonant ternary operator
                Console.WriteLine("Enter character");
                char cha = Convert.ToChar(Console.ReadLine());
                string res = (cha == 'a' || cha == 'e' || cha == 'i' || cha == 'o' || cha == 'u') ? "Vowel" : "Consonant";
                Console.WriteLine("char is" + res);

            }

        }
        class leapyYear
        {
            static void Main(string[] args)
            {
                //leap year

                Console.WriteLine("Enter Year");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
                {
                    Console.WriteLine(year + " is leap year");
                }
                else
                {
                    Console.WriteLine(year + "is not leap year");
                }
            }
                

            

                
            


        }
    }
}


        
            

            
             

            

            
            
               
            







        
    

