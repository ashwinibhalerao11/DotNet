using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.WeekTests
{
    internal class Shopping
    {
        public void doTransaction(string type)
        {
            Console.WriteLine("You have 15% discount on bill on credit card transaction..");
        }

        public void doTransaction(int amount, string type)
        {
            Console.WriteLine("No discount on other type of transaction");
        }

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.doTransaction("Credit Card");
            s.doTransaction(4599, "Cash");
        }
    }
}
