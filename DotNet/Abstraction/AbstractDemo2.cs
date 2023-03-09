using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Abstraction
{
    abstract class Mobile
    {

        public abstract void Memory();
    }

    internal abstract class Apple : Mobile
    {

        public abstract void Colour();
    }

    internal class Iphone : Apple
    {


        public override void Colour()
        {
            // throw new NotImplementedException();

            Console.WriteLine("Red");
        }

        public override void Memory()
        {
            //throw new NotImplementedException();
            Console.WriteLine("8GB");
        }
    }
    internal class AbstractDemo2
    {
        static void Main(string[] args)
        {
            Iphone I = new Iphone();
            I.Memory();
            I.Colour();
        }
    }
}
