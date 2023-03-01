using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.loop
{
    internal class forloop
    {
        static void Main(string[] args)


        {
            // odd no between 35 to 50
            for (int i = 35; i <= 50; i++)
            {

                if (i % 2 != 0) 
                {
                    Console.WriteLine(i);
                }
            }





            // sum of 1 to 10 numbers
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of 1 to 10: " + sum);


            //count odd number between 20 to 50
            int count1 = 0;
            for(int i =20;i<=50;i++)
            {
                if (i%2!=0)
                {
                    count1++;
                }
            }
            Console.WriteLine("total count: " + count1);



            //Display table of given no

            Console.WriteLine("Enter the number for table");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);

            }


            // numbers betwwen 320 t 225
            for (int i = 320; i >= 225; i--)
            {
                Console.WriteLine(i);
            }



        

        }
    }
}

               








        
    

