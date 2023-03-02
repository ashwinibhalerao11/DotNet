using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNet.OOPs
{
    internal class Account
    {
        string name;
        long accno;
        double accbalc;

        public string Name
        {
            set
            {
                name = value;

            }
            get
            {
                return name;
            }
        }
        public long AccNo
        {
            set
            {
                accno = value;

            }
            get
            {
                return accno;
            }
        }
        public double AccBalc
        {

            get
            {
                return accbalc;

            }
            set
            {
                accbalc = value;
            }
        }

    }
    class AccountDemo
    {
        static void Main(string[] args)
        {
            Account Acc = new Account();
            Acc.Name = "Ashwini Bhalero";
            Acc.AccNo = 0327011076662;
            Acc.AccBalc = 10500.76;

            string aname = Acc.Name;
            Console.WriteLine("Account holder Name: "+aname);
            Console.WriteLine("Account Number: "+Acc.AccNo);
            Console.WriteLine("Account Balance: "+Acc.AccBalc);


        }
    }
}






        

    

        

        















    
 
    

   




