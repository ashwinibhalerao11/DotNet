using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Method_Overloading
{
    internal class ConstructCar
    {

        public ConstructCar(string brand,int price)
        {
            Console.WriteLine("Brand: "+brand);
            Console.WriteLine("Price: "+price);
        }
        public ConstructCar(double speed, string colour)
        {
            Console.WriteLine("Speed: "+speed+"km/hr");
            Console.WriteLine("Color: "+colour);
        }
        static void Main(string[] args)
        {
             ConstructCar C = new ConstructCar("Hyundai CREATA",1900000);
            ConstructCar C2 = new ConstructCar(80,"Black");
        }
    }
}
