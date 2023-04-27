using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.CrudOperations
{
    public class Student1
    {

        public int Rollno { get; set; }
        public string Name { get; set; }
        public int Per { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student1> students;
        public StudentCRUD()
        {
            students = new List<Student1>();
        }
        public void AddStudent(Student1 student)
        {
            students.Add(student);
        }
        public void UpdateStudent(Student1 student)
        {
            foreach (Student1 s in students)
            {
                if (s.Rollno == student.Rollno)
                {
                    s.Name = student.Name;
                    s.Per = student.Per;
                }
            }
        }
        public void DeleteStudent(int rollno)
        {
            foreach (Student1 s in students)
            {
                if (s.Rollno == rollno)
                {
                    students.Remove(s);
                    break;
                }
            }
        }
        public List<Student1> GetStudents()
        {
            return students;
        }

        public Student1 GetStudentByRollno(int rollno)
        {
            Student1 student = new Student1();
            foreach (Student1 s in students)
            {
                if (s.Rollno == rollno)
                {
                    student = s;
                    break;
                }
            }
            return student;
        }
    }
    public class Program3
    {
        static void Main(string[] args)
        {
            StudentCRUD stud = new StudentCRUD();
            int op = 0;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. View All");
                Console.WriteLine("5. View by Rollno");
                Console.WriteLine("6. Price less than 1000");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Student1 s1 = new Student1();
                        Console.WriteLine("Enter Rollno");
                        s1.Rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        s1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        s1.Per = Convert.ToInt32(Console.ReadLine());
                        stud.AddStudent(s1);
                        break;
                    case 2:
                        Student1 s2 = new Student1();
                        Console.WriteLine("Enter Rollno");
                        s2.Rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        s2.Per = Convert.ToInt32(Console.ReadLine());
                        stud.UpdateStudent(s2);
                        break;
                    case 3:
                        Console.WriteLine("Enter Rollno");
                        int rollno = Convert.ToInt32(Console.ReadLine());
                        stud.DeleteStudent(rollno);
                        break;
                    case 4:
                        List<Student1> list = stud.GetStudents();
                        Console.WriteLine("Rollno \t Name \t Per");
                        foreach (Student1 item in list)
                        {
                            Console.WriteLine($"{item.Rollno} \t {item.Name} \t {item.Per}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter Rollno");
                        int rollno2 = Convert.ToInt32(Console.ReadLine());
                        Student1 item2 = stud.GetStudentByRollno(rollno2);
                        Console.WriteLine("Rollno\t Name \t Per");
                        Console.WriteLine($"{item2.Rollno} \t {item2.Name} \t {item2.Per}");
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

