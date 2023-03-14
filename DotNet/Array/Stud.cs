using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class Stud
    {
        int id;
        string name;
        int[] marks;

        public Stud(int id, string name, int[] marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public override string ToString()
        {
            return this.id + " " + this.name + " " + string.Join(" ",marks);

        }
    }
    class ObjectArray
    {
        static void Main(string[] args)
        {
            Stud[] s = new Stud[3];

            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine("Enter the id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name");
            }

        }
    }
}
