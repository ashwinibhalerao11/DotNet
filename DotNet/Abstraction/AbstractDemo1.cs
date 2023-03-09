using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Abstraction
{
    abstract class Animal
    {
        public abstract void MakeSound();
        
    }
    class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    internal class AbstractDemo1
    {
        static void Main(string[] args)
        {
            Animal A = new Cat();
            A.MakeSound();
        }
    }
}
