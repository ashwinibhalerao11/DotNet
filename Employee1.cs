using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.CrudOperations
{
    public class Employee1
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeCRUD
    {
        private List<Employee1> employee;
        public EmployeeCRUD()
        {
            employee = new List<Employee1>();
        }
        public void AddEmployee(Employee1 emp)
        {
            employee.Add(emp);
        }
        public void UpdateEmployee(Employee1 emp)
        {
            foreach (Employee1 e in employee)
            {
                if (e.Id == emp.Id)
                {
                    e.Name = emp.Name;
                    e.Salary = emp.Salary;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach (Employee1 e in employee)
            {
                if (e.Id == id)
                {
                    employee.Remove(e);
                    break;
                }
            }
        }
        public List<Employee1> GetEmployees()
        {
            return employee;
        }

        public Employee1 GetEmployeeById(int id)
        {
            Employee1 emp = new Employee1();
            foreach (Employee1 e in employee)
            {
                if (e.Id == id)
                {
                    emp = e;
                    break;
                }
            }
            return emp;
        }
    }
    public class Program4
    {

        static void Main(string[] args)
        {
            EmployeeCRUD employee = new EmployeeCRUD();
            int op = 0;
            do
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. View All");
                Console.WriteLine("5. View by Id");
                Console.WriteLine("6. Price less than 1000");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Employee1 em = new Employee1();
                        Console.WriteLine("Enter Id");
                        em.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        em.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        em.Salary = Convert.ToInt32(Console.ReadLine());
                        employee.AddEmployee(em);
                        break;
                    case 2:
                        Employee1 em1 = new Employee1();
                        Console.WriteLine("Enter Id");
                        em1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        em1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        em1.Salary = Convert.ToInt32(Console.ReadLine());
                        employee.UpdateEmployee(em1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employee.DeleteEmployee(id);
                        break;
                    case 4:
                        List<Employee1> list = employee.GetEmployees();
                        Console.WriteLine("Id \t Name \t Salary");
                        foreach (Employee1 item in list)
                        {
                            Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Salary}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Employee1 item2 = employee.GetEmployeeById(id2);
                        Console.WriteLine("Id \t Name \t Salary");
                        Console.WriteLine($"{item2.Id} \t {item2.Name} \t {item2.Salary}");
                        break;
                    default:
                        Console.WriteLine("No option available");
                        break;
                }

                Console.WriteLine("Do you want to continue ");
                op = Convert.ToInt32(Console.ReadLine());
            }
            while (op == 1);
        }
    }

}

