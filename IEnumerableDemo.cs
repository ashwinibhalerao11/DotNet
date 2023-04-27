using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public class Products
    {
        private string name;
        private int price;

        public Products(string name,int price)
        {
            this.name = name;
            this.price = price;
        }
        public int CompareTo(Products other)
        {
            if (this.price < other.price)
            {
                return -1;
            }
            else if (this.price > other.price)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public override string ToString()
        {
            return $"{name} - {price}";
        }
    }
    public class Productlist:IEnumerable
    { 
        private Products[] product;
        public Productlist() 
        { 
            product = new Products[4];
            product[0] = new Products("Mouse",600);
            product[1] = new Products("Keyboard", 1000);
            product[2] = new Products("Mouse Pad", 200);
            product[0] = new Products("Net Protector", 800);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return product.GetEnumerator ();
        }
    }
    public class IEnumerableDemo
    {
        static void Main(string[] args)
        {
          Productlist plist = new Productlist();

            foreach (Products p in plist)
            {
                Console.WriteLine(p);
            }

        }
    }
}
