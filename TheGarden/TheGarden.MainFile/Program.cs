using System;
using TheGarden.Library;
using TheGarden.DataAccess;



namespace TheGarden.MainFile
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var shop = new Store();
            shop.ShopLocation();
            shop.Welcome();

            var shopper = new Customers();
            shopper.CustomerName();
            shopper.Thankyou();
            shopper.Options();

// This is where we can check if my database is working.

            Console.Clear();
            Console.WriteLine("Would you like to see if my database is working? (y/n)");
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Type in a customer's name you would like to check.");
            Console.WriteLine();
            string dataCheck = Console.ReadLine();
            var table = new CheckTables();
            table.CheckCustomer(dataCheck);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Would you like to check my inventory? (y/n)");
            var answer = Console.ReadLine();
            if(answer == "y")
            {
            Console.WriteLine("Which plant would you like to check?");
            var planttype = Console.ReadLine();
            Console.WriteLine();
            table.CheckOrder(planttype);

            }

        }
    }
}
