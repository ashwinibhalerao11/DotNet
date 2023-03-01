using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.OOPs
{
    internal class Employee
    {
        int id;
        string name;
        double salary;
                     



        static void Main(string[] args)
        {
            Employee E1 = new Employee();
            E1.id = 101;
            E1.name = "Ashwini";
            E1.salary = 40000;
            Console.WriteLine("Employee id: "+E1.id);
            Console.WriteLine("Employee Name: " + E1.name);
            Console.WriteLine("Employee Salary: " + E1.salary);





        }
    }                   
}
