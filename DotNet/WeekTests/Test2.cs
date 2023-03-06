using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.WeekTests
{
    internal class Test2
    {

        // LQue1
        // print no between 1 to 100 except no divisible by 5 and 10
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
       
    }
    class LQue2
    {
        // print factors of o
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class LQue3
    {
        // print no from 1to50 if no is even then print as it is and no is odd print its square
        static void Main(string[] args)
        {
            for (int i= 1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                if(i%2!=0)
                {
                    int s = i * i;
                    Console.WriteLine(i+" Square "+s);
                }

            }
        }
    }
    class LQue4
    {
        // fibbo series
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 20; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.WriteLine();

        }
    }
    class LQue5
    {
        // check no is harshad or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = n1;
            while(n1>0)
            {
                int digit = n1 % 10;
                sum = sum + digit;
                n1 = n1 / 10;

            }
            if(temp%sum==0)
            {
                Console.WriteLine("No is Harshad");
            }
            else
            {
                Console.WriteLine("No is not Harshad");
            }
        }
    }
    class LQue6
    {
        // print no from 1 to 100 "redblue" no
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i+" RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine(i+" Red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine(i+" Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class LQue7
    {
        // write property of hotel

    }
    class Order
    {
        private int order_id;
        private string city;
        private string cust_name;
        private string isdelivered;

        public int Order_id
        {
            set
            {
                order_id = value;
            }
            get
            {
                return order_id;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string Cust_Name
        {
            set
            {
                cust_name = value;
            }
            get
            {
                return cust_name;
            }
        }
        public string IsDelivered
        {
            set
            {
                isdelivered = value;
            }
            get
            {
                return isdelivered;
            }
        }
    }
    class OrderDeatils
    {
        static void Main(string[] args)
        {
            Order O = new Order();
            O.Order_id = 101;
            O.City = "Pune";
            O.Cust_Name = "Ashu";
            O.IsDelivered = "No";
            Console.WriteLine(O.Order_id+" " +O.City+" "+O.Cust_Name+" "+O.IsDelivered+" ");
        }
    }
    class LQue8
    {
        // Krishnamurthy no or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int digit = num % 10;
                int fact = 1;
                for(int i=1;i<=digit;i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
                if (sum==temp)
                {
                    Console.WriteLine("Krishnamurthy Number");
                }
                else
                {
                    Console.WriteLine("Not Kirishnamurthy Number");
                }
            }
        }
    }
}
