using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.WeekTests.Array_Test
{
    internal class Test4
    {
        // Q2 Predict the output
        

        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
        }
    }
    class EvenOddArray
    {
        // Q1 find even and odd elements in array
        static void Main(string[] args)
        {
            int evenflag = 0; int oddflag = 0;
            Console.WriteLine("Enter the size of array:");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            Console.WriteLine("Enter the element to the array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    evenflag++;
                }
                else
                {
                    oddflag++;
                }
            }
            Console.WriteLine("Number of even element in array is: " + evenflag);
            Console.WriteLine("Number of odd element in array is: " + oddflag);
        }
    }
    class Numbers
    { 
        // Q9
        public static void Main(String[] args)
        {
            int []var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] +" ");
                i++;
            }
        }
    }
    public class ArrayOuput
    {
        //Q11
        public static void Main(String[] args)
        {
            
            int []a1 ={ 1,2,3};
            int[] a2 = new int[3];
            a2 = new int [a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {

                Console.WriteLine(a2[i]);
            }
        }
    }
    class Pen
    {
        // Q4 get set property
        string refill;
        int caplength;
        string brand;
        string materialtype;
        int width;
        string inkcolour;
        int length;
        string nib;

        public string Refill
        {
            get { return refill; }
            set { refill = value; }
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public string Inkcolour
        {
            get { return inkcolour; }
            set { inkcolour = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        static void Main(string[] args)
        {
            Pen P = new Pen();
            P.refill = "Gel Pen Refill";
            P.caplength=2;
            P.brand="Classmates";
            P.materialtype="Steel";
            P.width=2;
            P.inkcolour="Black";
            P.length=4;
            P.nib = "Small";

            Console.WriteLine(P.refill);
            Console.WriteLine(P.caplength);
            Console.WriteLine(P.brand);
            Console.WriteLine(P.materialtype);
            Console.WriteLine(P.width);
            Console.WriteLine(P.inkcolour);
            Console.WriteLine(P.length);
            Console.WriteLine(P.nib);

        }
    }
    class Frequency
    {
        // 3. Write a program to find Minimum frequency char from an Array
       //e.g char arr[] = {‘a’,’b’,’b’,’c’,’c’,’b’};
       // output= a
      
       static void Main(string[] args)
       {
           char[] arr = { 'a', 'b', 'b', 'c', 'c', 'b' };
           char ch = arr[0];
           int freq = 0;
           for (int i = 0; i < arr.Length; i++)
           {
             if (arr[i] < ch)
             {
                ch = arr[i];
                freq = 0;

             }

             else if (arr[i] == ch)
             {
                    freq++;
             }

           }
           Console.WriteLine(ch);
           Console.WriteLine(freq);
       }
 
    }
    class ZerosFromNonZeros
    {
        static void Main(string[] args)
        {
            // Q6 WAP to separate zeros from non zero in int type array
            //Input Array : [12, 0, 7, 0, 8, 0, 3]
            //Input Array After moving zeros to end:
            //[12, 7, 8, 3, 0, 0, 0]

            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            int n = a.Length;
            int j = 0;
            for(int i=0;i<n;i++)
            {
                if (a[i]!=0)
                {
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                    j++;
                }
            }
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(a[i]+" ");
                //Console.WriteLine(" ");
            }

        }
    }




}

