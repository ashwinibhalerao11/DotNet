using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public class GenericDemo
    {
        static void Main(string[] args)
        {


            List<int>list1= new List<int>();
            list1.Add(3);
            list1.Add(6);
            list1.Add(15);
            list1.Add(22);

            int[] a = new int []{ 1, 2, 3, 4, 5 };
            list1.AddRange(a);
            list1.Insert(2,9);

            Console.WriteLine($"Count is {list1.Count}");
            Console.WriteLine($"Count of Array List {list1.Count}");

            list1.Remove(2);
            list1.RemoveAt(3);

            
            
          

            List<string> list = new List<string>();
            list.Add("Ashwini");
            list.Add("Bhalerao");
            list.Add("Yellow");
            list.Add("Pink");

            list.Insert(1,"blue");
            list.Insert(2, "Pratik");


            Console.WriteLine($"Count is {list.Count}");
            Console.WriteLine($"Count of Array List {list.Count}");
            list.Remove("yellow");
            list.RemoveAt(1);
            list.RemoveRange(1, 2);


            list.Sort();
            list.Reverse();

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
