using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DotNet.WeekTests
{
    internal class Test3
    {
       //Q1 Constructor Chaining
    }
    class  College_Department
    {
        public int did;
        public string dname;

        public College_Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void DisplayDept()
        {
            Console.WriteLine("Deopartment id: "+did+"Department name: "+dname);
        }
        
    }
    class Student
    {
        int id;
        string name;
        College_Department dept;

         Student(int id,string name,College_Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        public void ShowStud()
        {
            Console.WriteLine("Student Id: "+id+"Student Name: "+name);
            dept.DisplayDept();

        }
        
        static void Main(string[] args)
        {
            College_Department D = new College_Department(1,"Psychology Department");
            Student S = new Student(104,"Rutu Bhalerao",D);
            S.ShowStud();
        }
    }


 
    class Dog
    {
        //Q2 Use of base keyword

        internal  string colour;
    }
    class Bulldog:Dog
    {
        private string colour = "Black";
        public void ShowColour()
        {
            Console.WriteLine(colour + " " + base.colour);
        }

    }
    class TQue2
    {       
        static void Main(string[] args)
        {
            Bulldog D = new Bulldog();
            D.ShowColour();
        }
    }
    class TQue4
    {
        // Print Pettern
        static void Main(string[] args)
        {
            for(int i=1;i<=7;i++)
            {
                for(int j=7;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    if(i%2!=0)
                    {
                        Console.Write(k+" ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class TQue5
    {
        // National GAmes Using Switch
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Country Name");
            Console.WriteLine("India \n China \n Bangladesh \n Italy \n United States");
            string country = Console.ReadLine();

            switch (country)
            {
                case ("India"):
                    Console.WriteLine("Hockey");
                    break;
                case ("China"):
                    Console.WriteLine("Table Tennis");
                    break;
                case ("Bangladesh"):
                    Console.WriteLine("Kabaddi");
                    break;
                case ("Italy"):
                    Console.WriteLine("Football");
                    break;
                case ("United States"):
                    Console.WriteLine("Baseball");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
    
    class Car
    {
        //Que7 Predict the output

        public String color;
        public void changeColor(Car c2)
        {
            c2.color = color;
            color = "Red";
        }
    }
    class Demo
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.color = "Blue";
            Car c2 = new Car();
            c2.changeColor(c1);
            c2.color = "Pink";
            Console.WriteLine(c1.color);
            Console.WriteLine(c2.color);
        }
    }
    






}
