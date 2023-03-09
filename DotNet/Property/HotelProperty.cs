using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Property
{
    internal class HotelProperty
    {
        int hid;
        string hname;
        string hloacation;
        double hrating;
        bool isOnlineorderAvailable;
        string seatingCapasity;
        string paymentType;

        private int Hid
        {
            set
            {
                hid = value;
            }
            get
            {
                return hid;
            }
        }
        private string Hname
        {
            set
            {
                hname = value;
            }
            get
            {
                return hname;
            }
        }
        private string Hlocation
        {
            set
            {
                hloacation = value;
            }
            get
            {
                return hloacation;
            }
        }
        private double Hrating
        {
            set
            {
                hrating = value;
            }
            get
            {
                return hrating;
            }
        }
        private bool IsOnlineorderAvailable
        {
            set
            {
                isOnlineorderAvailable = value;
            }
            get
            {
                return isOnlineorderAvailable;
            }
        }
        private string seatingCapacity
        {
            set
            {
                seatingCapacity = value;
            }
            get
            {
                return seatingCapacity;
            }
        }
        private string PaymentType
        {
            set
            {
                paymentType = value;
            }
            get
            {
                return paymentType;
            }
        }
        static void Main(string[] args)
        {
            HotelProperty hotel = new HotelProperty();
            hotel.Hid = 5554;
            hotel.Hname = "Samudra Pure Veg";
            hotel.Hlocation = "Pune-Maharashtra";
            hotel.Hrating = 5;
            hotel.IsOnlineorderAvailable = false;
            //hotel.seatingCapacity = "100";
            hotel.PaymentType = "Cash-Online";
            Console.WriteLine(hotel.Hid + " " + hotel.Hname + " " + hotel.Hlocation + " " + hotel.Hrating + " " + hotel.IsOnlineorderAvailable + " " + hotel.PaymentType);
            
        }

    }
}
