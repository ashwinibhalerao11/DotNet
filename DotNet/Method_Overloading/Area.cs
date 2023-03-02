using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Method_Overloading
{
    internal class Area
    {
        public void area(int side)
        {
            Console.WriteLine("Area of Square= "+side*side);
        }


        public void  area(float radius)
        {
            Console.WriteLine("Area of Circle= "+3.14f*radius*radius);
        }


        public void area(int Height,int Base)
        {
            Console.WriteLine("Area of Triangle= "+(Height*Base)/2);
        }


        public void area(int Length,double Breadth)
        {
            Console.WriteLine("Area of Rectangle= "+Length*Breadth);
        }


       
        static void Main(string[] args)
        {
            Area A = new Area();
            A.area(12);
            A.area(9);
            A.area(13,12);
            A.area(10,20);



        }
    }
}
