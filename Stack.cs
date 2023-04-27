using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.Pop();
            Console.WriteLine($"Top element on the stack {stack.Peek()}");
            Console.WriteLine($"elements on the stack {stack.Count}");
            foreach (object i in stack)
            {
                Console.WriteLine(i);
            }

        }
    }
}
