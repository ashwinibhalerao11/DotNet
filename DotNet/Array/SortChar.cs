using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class SortChar
    {
        public static void SortCharArray(char[] array)
        {
           Console.WriteLine(string.Join(" ", array));
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] < array[j])
                    {
                        char temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            SortChar ch = new SortChar();
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            char[] array = new char[size];
            Console.WriteLine("Enter Elements of Array");
            for(int i=0;i<size;i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());

            }
            SortChar.SortCharArray(array);


            Console.WriteLine(string.Join(" ",array));
        }
    }
}
