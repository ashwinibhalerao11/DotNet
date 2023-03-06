using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.SingleInheritance
{
    internal class Animal
    {

        internal int leg = 4;
    }
    class Dog : Animal
    {
        string voice = "Barking";
        string breed = "Bull Dog";
        public void Show()
        {
            Console.WriteLine(leg+" "+voice+" "+breed);
        }
    }
    class InheritDemo
    {
        static void Main(string[] args)
        {
            Dog D = new Dog();
            D.Show();

        }
    }
}
