using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Method_Overloading
{
    internal class ConstructorOverload
    {
        string name;
        int qty;
        int price;
        public ConstructorOverload(string name, int qty,int price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public int Qty
        {
            set
            {
                this.qty = value;
            }
            get
            {
                return this.qty;
            }
        }
        public int Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }



        static void Main(string[] args)
        {
            ConstructorOverload c = new ConstructorOverload("Parle",2,10);
            c.name = "Bourbon";
            c.qty = 2;
            c.price = 10;
            Console.WriteLine("Name= " + c.name);
            Console.WriteLine("Qty= " + c.qty);
            Console.WriteLine("Price= " + c.price);

        }
    }
}
