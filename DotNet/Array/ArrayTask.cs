using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Array
{
    internal class ArrayTask
    {
        // create one int type array and replace elements by zero which are divisible by 5

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 7, 10,15 };
            for(int i=0;i<arr.Length;i++)
            {
                if(i%5==0)
                {
                    arr[i] = 1;
                }
            }
        }
     

    }
}
