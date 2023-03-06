using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.Mutilevel
{
    internal class Vehicle
    {
        protected string fuel = "Disel,Petrol";
        protected int wheels = 4;

    }
    class Car1:Vehicle
    {
        protected string use = "Travelling";
    }
    class SedanSwift:Car1
    {
        string colour = "White";
        string seats = "4 Seater";
        public void ShowCar()
        {
            Console.WriteLine(fuel+" "+wheels+" "+use+" "+colour+" "+seats);
        }
    }
    class InheritDemo3
    {
        static void Main(string[] args)
        {
            SedanSwift SS = new SedanSwift();
            SS.ShowCar();
        }
    }
}
