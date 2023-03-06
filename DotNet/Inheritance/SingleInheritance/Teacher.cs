using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Inheritance.SingleInheritance
{
    internal class Teacher
    {
        internal string teacher = "Teaches";
    }
    class Student1:Teacher
    {
        string student = "Learn";
        public void Show()
        {
            Console.WriteLine(teacher+" "+student);
        }
    }
    class InheritDemo2
    {
        static void Main(string[] args)
        {
            Student1 S=new Student1();
            S.Show();

        }
    }
}
