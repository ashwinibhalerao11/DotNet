using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.CrudOperations
{
    public class Product2
    {
        private string name;
        private int price;

        public string Name
        {
            get { return name; }
        }
        public int Price
        {
            get { return price; }
        }

        public Product2(string name, int price)
        {
            this.name = name;
            this.price = price;
        }


        public override string ToString()
        {
            return $"{name},{price}";
        }


    }

    public class Item : IComparer<Product2>
    {
        public int Compare(Product2 x, Product2 y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            else if (x.Price > y.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }


    public class Program2
    {
        static void Main(string[] args)
        {
            Product2 Book = new Product2("Book", 500);
            Product2 Pen = new Product2("Pen", 100);
            Product2 Pencil = new Product2("Pencil", 50);

            Item item = new Item();
            int result = item.Compare(Book, Pen);

            if (result == 1)
            {
                Console.WriteLine("Book having more price than pen");
            }
            else if (result == 2)
            {
                Console.WriteLine("book having less price than pen");
            }
            else
            {
                Console.WriteLine("Both having same price");
            }
        }
    }
}
