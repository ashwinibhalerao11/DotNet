using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Contenment
{
    internal class Nib
    {
        string materialType;
        int price;
        public Nib(string materialType, int price)
        {
            this.materialType = materialType;
            this.price = price;
        }
        public void showNib()
        {
            Console.WriteLine(materialType + " " + price);
        }
    }
    internal class Pen
    {
        string color;
        string name, Type;
        Nib nib;

        public Pen(string color, string name, string type, Nib nib)
        {
            this.color = color;
            this.name = name;
            Type = type;
            this.nib = nib;
        }
        public void showPen()
        {
            Console.WriteLine(color + " " + name + " " + Type);
            nib.showNib();
        }
    }
    class Bag
    {
        string Brand, color;
        int price;
        Pen pen;

        public Bag(string brand, string color, int price, Pen pen)
        {
            Brand = brand;
            this.color = color;
            this.price = price;
            this.pen = pen;
        }
        public void showBag()
        {
            Console.WriteLine(Brand + " " + color + " " + price);
            pen.showPen();
        }

        static void Main(string[] args)
        {
            Nib n = new Nib("steel", 20);
            Pen p = new Pen("Blue", "Reynold", "Boll Pen", n);
            Bag b = new Bag("Adidas", "Black", 500, p);
            //n.showNib();
            p.showPen();
            b.showBag();
        }
    }


}

