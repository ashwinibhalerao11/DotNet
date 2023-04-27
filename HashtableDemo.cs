using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Collection
{
    public  class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(91, "IND");
            hashtable.Add(63, "AUS");
            hashtable.Add(1, "USA");
            hashtable.Remove(1);
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

        }
    }
}
