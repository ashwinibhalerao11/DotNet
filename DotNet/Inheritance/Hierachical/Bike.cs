using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.Hierachical
{
    internal class Bike
    {
        public int Wheels = 2;
    }
    class Scooty : Bike
    {
        public string function = "No Gears";
         public void showScooty()
         {
            Console.WriteLine(function+" "+Wheels);
         }
    }
    class Bullet : Bike
    {
        public string model = "Classic 350";
        public void shoeBullet()
        {
            Console.WriteLine(model+" "+Wheels);
        }
    }
    class HierachicalDemo2
    {
        static void Main(string[] args)
        {
            Scooty S = new Scooty();
            S.showScooty();
            Bullet B = new Bullet();
            B.shoeBullet();
        }
    }
}
