using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Method_Overloading
{
    internal class Satic_Overload
    {
        

        public static void Reverse(ref int a)
        {
            int d = 0;          

            while(a>0)
            {
                a = a % 10;
                d = (d * 10) + a;
                a = a / 10;
                
            }
            Console.WriteLine(d);


            
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Reverse= "+num1);
            Satic_Overload.Reverse(ref num1);



            Console.WriteLine("Reverse is= "+num1);

        }
    }
    class Swapping
    {
        public static void Swap(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("In Method= "+n1+" "+n2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Berfor Swap= "+num1+" "+num2);
            Swapping.Swap(ref num1, ref num2);
            Console.WriteLine("After Swap= "+num1+" "+num2);

        }
    }
}
