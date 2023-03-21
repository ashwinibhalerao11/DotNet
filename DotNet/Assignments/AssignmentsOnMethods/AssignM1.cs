using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Assignments.AssignmentsOnMethods
{
    internal class AssignM1
    {
        //Calculate Square of given no with no return type and return type
        public void Squarenum(int a)
        {
            Console.WriteLine("Square= " + (a * a));
        }
        public int Square(int a)
        {
            int square = a * a;
            return square;
        }
        static void Main(string[] args)
        {
            AssignM1 A = new AssignM1();
            A.Squarenum(4);
            Console.WriteLine("Square= " + A.Square(15));
        }
    }
    class AssignM2
    {
        //Calculate Cube of given no with no return type and return type
        public void Cubenum(int c)
        {
            Console.WriteLine("Cube= " + (c * c * c));
        }
        public int Cube(int c)
        {
            int cube = c * c * c;
            return cube;
        }
        static void Main(string[] args)
        {
            AssignM2 A = new AssignM2();
            A.Cubenum(23);
            Console.WriteLine("Cube= " + A.Cube(10));
        }
    }
    class AirthmetcOperations
    {
        // perform airthmetic operations

    }
}


