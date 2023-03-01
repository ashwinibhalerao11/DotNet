using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.OOPs
{
    internal class Car
    {
        string CName;
        string Cmodel;
        string CColour;
        double Cprice;




        static void Main(string[] args)
        {
            Car C1 = new Car();
            C1.CName = "Hyundai";
            C1.Cmodel = "Verna";
            C1.CColour = "White";
            C1.Cprice = 1364566;
            Console.WriteLine("C1.CName: " + C1.CName);
            Console.WriteLine("C1.Cmodel: " + C1.Cmodel);
            Console.WriteLine("C1.CColour: "+C1.CColour);
            Console.WriteLine("C1.CColour: "+C1.CColour);






        }
    }
}
