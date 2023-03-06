using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Contenment
{
    internal class Order
    {
        int Oid;
        int Qty;
        Menue m; 

        public Order(int Oid, int Qty,Menue m)
        {
            this.Oid = Oid;
            this.Qty = Qty;
            this.m = m;
        }
        public void Show()
        {
            Console.WriteLine(Oid + " " + Qty);
            Menue M = new Menue(101, "Kaju Curry", 250);
            M.ShowMenue();
            
        }              
        
    }
    class Menue
    {
        int Mid;
        string Item;
        double Price;
        public Menue(int Mid,string Item,double Price)
        {
            this.Mid = Mid;
            this.Item = Item;
            this.Price = Price;


        }
        public void ShowMenue()
        {
            Console.WriteLine(Mid+" "+Item+" "+Price+"Rs");
            
        }


        static void Main(string[] args)
        {
            Menue M = new Menue(101, "Kaju Curry", 250);
            Order O = new Order(101,1,M);
            O.Show();


        }
    }
}
