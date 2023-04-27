using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public  class GenericStack
    {
        static void Main(string[] args)
        {
            Stack<int> stack= new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);  
            stack.Push(4);  
            stack.Push(5);

            stack.Pop();
            Console.WriteLine($"Top Element on stack {stack.Peek()}");
            Console.WriteLine($"Count of stack elements {stack.Count}");

            foreach (object i in stack)
                Console.WriteLine(i);
        }
    }
}
