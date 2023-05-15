using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    public delegate void MyDelegate1();//define delegate -- signature should match with the method signature
    public class Bank
    {
        public event MyDelegate1 InsufficientBalance; //first Event Name
        public event MyDelegate1 LowBalance;//Second Event Name
        int balance;
        public Bank()
        {
            balance = 10000;
        }
        public void Credit(int amount)
        {
            balance += amount;
        }
        public void Debit(int amount)
        {
            if (amount > balance)
            {
                InsufficientBalance();
            }
            else
            {
                balance -= amount;
                if (amount < 3000)
                {
                    LowBalance();
                }

            }
        }
        public override string ToString()
        {
            return $"Current balance {balance}";
        }

    }
    public class Program1
    {
        static void Message()
        {
            Console.WriteLine("You have Insufficient Balance");
        }
        static void Message1()
        {
            Console.WriteLine("You have Low Balance");
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.InsufficientBalance += new MyDelegate1(Message);
            bank.LowBalance += new MyDelegate1(Message1);
            Console.WriteLine(bank);
            bank.Credit(5000);
            Console.WriteLine(bank);
            bank.Debit(16000);
            Console.WriteLine(bank);


        }
    }
}
