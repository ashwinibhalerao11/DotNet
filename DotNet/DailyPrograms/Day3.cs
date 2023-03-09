using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DailyPrograms
{
    internal class Day3
    {
        static void Main(string[] args)
        {
            // vowel and consonant
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
