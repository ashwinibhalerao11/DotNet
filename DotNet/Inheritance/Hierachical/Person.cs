using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.Hierachical
{
    internal class Person
    {
        public string name;
        public int adhar_id;
        public int age;        
    }
    class Teacher:Person
    {

        public double Income = 70000;
        public void ShowTeacher()
        {
            Console.WriteLine("Person name:Bhalerao sir "+name+"Adhar Id:23456712 "+56+" "+Income);
        }

    }
    class Doctor:Person
    {

        public string Branch = "Dermatolgist";
         
        
        public void ShowDoctor()
        {
            Console.WriteLine("Person name:Dr Thorat " + name + "Adhar Id:123456789" + 45 +" "+Branch);
        }
    }
    class HirachicalDemo1
    {
        static void Main(string[] args)
        {
            Teacher T = new Teacher();
            T.ShowTeacher();

            Doctor D = new Doctor();
            D.ShowDoctor();
        }
    }
}
