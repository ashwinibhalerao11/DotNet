using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Delegates
{
    //FOOD ORDER TRACKING SYSTEM

    public delegate void StatusDelegate(int a);
    public class FoodOrderTracking
    {
        public void GetFoodStatus(StatusDelegate statusDelegate)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000);
                int FoodStatus = i;
                statusDelegate(FoodStatus);
            }
        }
    }
    public class Program2
    {
        public static void MyFoodStutus(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Food Order Received");
                    break;
                case 2:
                    Console.WriteLine("Preparing Food");
                    break;
                case 3:
                    Console.WriteLine("Packing Food");
                    break;
                case 4:
                    Console.WriteLine("In transit");
                    break;
                case 5:
                    Console.WriteLine("Food Delivered");
                    break;
                default:
                    Console.WriteLine("Order cancelled");
                    break;
            }
        }
        static void Main(string[] args)
        {
            FoodOrderTracking food = new FoodOrderTracking();
            food.GetFoodStatus(MyFoodStutus);
        }
    }
}

