using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DotNet
{
    internal class Conditions

    {
        class ifelse
        {


            static void Main(string[] args)
            {
                // odd even

                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("odd");
                }


                Console.WriteLine("Enter the Number");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 >= 0)
                {
                    Console.WriteLine("Positive");
                }
                else
                {
                    Console.WriteLine("Negative");
                }


                // No is multiple of 3
                Console.WriteLine("Enter the number");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 % 3 == 0)
                {
                    Console.WriteLine("num is multiple of 3");
                }
                else
                {
                    Console.WriteLine("num is not multiple of 3");
                }
            }

        }


        class ifeleseladder
        {
            static void Main(string[] args)
            {

                // positive negative zero

                Console.WriteLine("Enter the Number");
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
                    Console.WriteLine("Zero");
                }

            }
        }
        class D3or9
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter number");
                int n1 = int.Parse(Console.ReadLine());

                if (n1 % 3 == 0 && n1 % 9 == 0)
                {
                    Console.WriteLine("divisible by 3 and 9");
                }
                else if (n1 % 3 == 0)
                {
                    Console.WriteLine("divible by 3 but not 9 ");
                }
                else
                {
                    Console.WriteLine("not divisible by 3 and 9");


                }

            }
        }
        class charalphadigi
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
            class grless
            {
                static void Main(string[] args)
                {

                    Console.WriteLine("Enter Number");
                    int number = int.Parse(Console.ReadLine());
                    if (number > 50 && number < 100)
                    {
                        Console.WriteLine("number is gr than 50 and less than 100");
                    }
                    else
                    {
                        Console.WriteLine("number is not gr than 50 and less than 100");

                    }



                }





            }
        }
    }
}





            
                
                    
                
             


                    

                
                    
                    

                    
                


                    

                      
                
                
                


            
            
                
                
                
                
        


    

        






















        
        
            
                

                        

                      
                    













                
            
                
                         


                    






                
            




        

         


    

