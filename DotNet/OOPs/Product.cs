using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNet.OOPs
{
    internal class Product
    {
        string Name;
        double Price;
        int Qty;


        public void AcceptProductDetails(string Pname,double PPrice,int PQty)
        {
            Name = Pname;
            Price = PPrice;
            Qty = PQty;

        }
        public void CalculateBill()
        {
            if(Qty>0)
            {
                Console.WriteLine("Calculate the Bill");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine(Name+" "+Price+" "+Qty);
        }
        static void Main(string[] args)
        {
            Product P = new Product();
            P.AcceptProductDetails("Soap",40.2,5);
            P.CalculateBill();
            P.DisplayProductDetails();
        }
            

    }
    class Factor
    {
        int num;
        public void GetDigit(int digit)
        {
            num = digit;
        }
        public void PutDigit()
        {
            for (int i = 1; i <= num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Factor f = new Factor();
            f.GetDigit(4);
            f.PutDigit();
        }
    }
    class Student
    {
        int id;
        string name;
        int marks;
        int m1,m2,m3;
        int Per;


        public void AcceptDetails(int sid, string sname, int mk1, int mk2, int mk3)
        {
            id = sid;
            name = sname;
            m1 = mk1;
            m2 = mk2;
            m3 = mk3;


        }
        public void CalculatePercentage()
        {
            Per = ((m1 + m2 + m3) * 100) / 300;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("id\t Name\t M1\t M2\t M3\t Percentage\t");
            Console.WriteLine(id+" " +name+" " +m1+" " +m2+" " +m3+" " +Per);


        }
        
        static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptDetails(101,"Ashwini",80,85,78);
            s.CalculatePercentage();
            s.DisplayDetails();

        }


    }
}
