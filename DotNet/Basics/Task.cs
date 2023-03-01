using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.consoleapp
{
    internal class task
    { 
        static void Main(string[] args)
        {
            // Area of Retangle 

            Console.WriteLine("area of rectangle");
            Console.WriteLine("enter the value of length and breadth");
            int l = Convert.ToInt32(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = l * b;
            Console.WriteLine(area);




            //Area of circle 

            Console.WriteLine("area of circle");
            Console.WriteLine("Enter value of radius");
            double rad = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double carea = pi * rad * rad;
            Console.WriteLine(carea);


            // Find cube

            Console.WriteLine();
            Console.WriteLine("cube of number");
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine(cube);


            // Find Average of three sub 

            Console.WriteLine();
            Console.WriteLine("Average of three subject");
            Console.WriteLine("enter marks of three subject");

            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());

            int avg = (sub1 + sub2 + sub3) / 3;
            Console.WriteLine(avg);


            // Percentage of 5 sub

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

            Console.WriteLine(percentage);

            //leap year

            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0 || (year % 400 == 0)))
                Console.WriteLine(year + "is leap year");
            else
                Console.WriteLine(year + "is not a leap year");


            




                













           
                







               
































        }
    }
}
    
