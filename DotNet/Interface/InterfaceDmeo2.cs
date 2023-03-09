using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Interface
{
    interface ILaptopable
    {
        public static string brand;
        public static int size;
        public void DisplayInfo();
    }

    internal interface IConfigurationable : ILaptopable
    {
        public static int ram;
        public static int ssd;
        public static string os;
        public void ShowInfo();

    }

    internal class Merge : IConfigurationable
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Name of Brand: " + ILaptopable.brand);
            Console.WriteLine("Screen size: " + ILaptopable.size);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Size of RAM is: " + IConfigurationable.ram);
            Console.WriteLine("Size of SSD is: " + IConfigurationable.ssd);
            Console.WriteLine("Operating System is: " + IConfigurationable.os);
        }
    }

   
   
     
    internal class InterfaceDmeo2
    {
        static void Main(string[] args)
        {
            Merge m = new Merge();

            Console.WriteLine("Enter the laptop brand name:");
            ILaptopable.brand = Console.ReadLine();
            Console.WriteLine("Enter the size in between 12'' to 16'': ");
            ILaptopable.size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Ram: ");
            IConfigurationable.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ssd: ");
            IConfigurationable.ssd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the os: ");
            IConfigurationable.os = Console.ReadLine();

            m.DisplayInfo();
            m.ShowInfo();
        }
    }
}
