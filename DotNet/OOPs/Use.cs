using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.OOPs
{
    internal class UseThis
    {
        int id;
        string Name;
        double Salary;
        string City;

       

        
        public UseThis(int eid, string eName, double eSalary, string eCity)
        {
            this.id = eid;
            this.Name = eName;
            this.Salary = eSalary;
            this.City = eCity;

        }
        public void showInfo()
        {
          
            Console.WriteLine(id  +  " "  + Name + " " + Salary + " " + City);

        }
    }
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            UseThis E1 = new UseThis(001, "Ashwini", 35000, "Pune");
            UseThis E2 = new UseThis(002, "Vishakha", 30000, "Mumbai");
            UseThis E3 = new UseThis(003, "Soha", 40000, "Khed");
            UseThis E4 = new UseThis(004, "Pratik", 45000, "Nashik");


            E1.showInfo();
            E2.showInfo();
            E3.showInfo();
            E4.showInfo();







        }
    }
}


     
        
          
        

        
        


        
    

