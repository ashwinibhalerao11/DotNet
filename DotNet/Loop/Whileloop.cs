using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.loop
{
    internal class Whileloop
    {
        static void Main(string[] args)
        {
            // Count digit from the number
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int Count = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                Count++;
                num = num / 10;

            }
            Console.WriteLine("count of number is " + Count);


        }
        class avgofdigit
        {
            static void Main(string[] args)
            {

                // Calculate avg of digits
                Console.WriteLine("Enter the number");
                int num1 = int.Parse(Console.ReadLine());
                int total = 0;
                int count1 = 0;
                while (num1 > 0)
                {
                    int number = num1 % 10;
                    total = total + number;
                    num1 = num1 / 10;
                    count1++;
                }
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Average: " + total / count1);
            }


            class Pallindrome
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter the number");
                    int num2 = int.Parse(Console.ReadLine());
                    int copy = num2;
                    int reverse = 0;
                    while (num2 > 0)
                    {
                        int digit = num2 % 10;
                        reverse = reverse * 10 + digit;
                        num2 = num2 / 10;

                    }
                    Console.WriteLine(reverse);
                    if (reverse == copy)
                    {
                        Console.WriteLine("Pallindrome Number");
                    }
                    else
                    {
                        Console.WriteLine("Not Pallindrome Number");
                    }







                }
            }


            class amstrongnum
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter the Number: ");
                    int num3 = int.Parse(Console.ReadLine());
                    int copy1 = num3;
                    int reverse1 = 0;
                    while (num3 > 0)
                    {
                        int digit = num3 % 10;
                        num3 = reverse1 + digit * digit * digit;
                        num3 = num3 / 10;

                    }
                    if (num3 == copy1)
                    {
                        Console.WriteLine("Amstrong Number");
                    }
                    else
                    {
                        Console.WriteLine("Not Amstrong Number");
                    }





                }
            }
            class whilepractice
            {
                static void Main(string[] args)
                {
                    // sum of 1 to 10 numbers
                    int i = 0;
                    int sum = 0;
                    while (i <= 10)
                    {
                        sum = sum + i;
                        i++;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}





               




                        





                    
                
            
        
    








                














            
        

            




            


        
    





           










            










        




    

