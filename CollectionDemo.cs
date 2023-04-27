using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
    public class CollectionDemo
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { Id = 1, Name = "Soap" };
            Product p2 = new Product { Id = 2,Name ="Body Wash" };

            ArrayList list = new ArrayList();
            list.Add(p1); 
            list.Add(p2);

            

        }
    }
}
