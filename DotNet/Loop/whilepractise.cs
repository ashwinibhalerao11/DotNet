using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.loop
{
    internal class whilepractise
    {
        static void Main(string[] args)
        {
            //table of given input

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(num + "x" + i + "=" + num * i);
                i++;
            }
        }

        class whilepractise1
        {
            static void Main(String[] args)
            {

                //number between 320 to 225
                int num1 = 320;
                while (num1 >= 225)
                {
                    Console.WriteLine(num1);
                    num1--;
                }
            }
        }
    }
}






            

    






        
    

