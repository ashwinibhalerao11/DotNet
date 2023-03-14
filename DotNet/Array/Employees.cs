using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class Employees
    {
       internal int id;
        internal string name;
        internal double salary;

        public Employees(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        public override string ToString()
        {
            return id + " " + name + " " + salary;
        }
        
    }
    class ArrayObject
    {
        static void Main(string[] args)
        {
            Employees[] Emp = new Employees[5];
            for(int i=0;i<Emp.Length;i++)
            {
                Console.WriteLine("Enter the Id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Salary");
                double salary = double.Parse(Console.ReadLine());

                Emp[i] = new Employees(id, name, salary);
            }
            for(int i=0;i<Emp.Length;i++)
            {
                Console.WriteLine(Emp[i]);
            }
            Console.WriteLine("----------------");
            foreach(Employees E in Emp)
            {
                if(E.salary>20000)
                {
                    Console.WriteLine(E);
                }
            }
                
        }
    }
}
