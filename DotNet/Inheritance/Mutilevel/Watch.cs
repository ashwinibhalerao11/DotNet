using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.Mutilevel
{
    internal class Watch
    {
        protected string Sfuction;
        protected string memory;
    }
    class SmartWatch:Watch
    {
        protected string memory;
        protected string Sfuction;
        protected void Memory()
        {
            Console.WriteLine(memory);
        }


    }
    class FossilWatch:SmartWatch
    {
        string memory = "4GB";
        string Sfunction = "Calling,Weather Update";
        public void ShowSfunction()
        {
            Console.WriteLine(Sfunction+" "+base.memory);
            base.Memory();
        }
    }
    class UseBase
    {
        static void Main(string[] args)
        {
            FossilWatch F = new FossilWatch();
            F.ShowSfunction();
            

        }
    }

    
}
