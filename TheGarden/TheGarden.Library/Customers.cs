using System;
using TheGarden.DataAccess.Model;


namespace TheGarden.Library
{
    public class Customers
    {
        public string first_name { get; set; }
        public string last_name { get; set;}
        public void CustomerName()
        {
        Console.WriteLine();
            Console.Clear();
            Console.WriteLine("To complete your order, please complete the fields below:");
            Console.WriteLine();
            Console.WriteLine("Enter first name here:");
            first_name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter last name here:");
            last_name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter street address here:");
            string addresss = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter city here:");
            string addy = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter state here:");
            string cali = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter zipcode here:");
            string zip = Console.ReadLine();

            using (var db = new LimsGardenContext())
            {
                var customer1 = new Customer
                 { 
                    FirstName = first_name,
                    LastName = last_name 
                 };
                db.Customer.Add(customer1);
                db.SaveChanges();
            }

       
        }

        // Different Methods

        public void Thankyou()
        {
            Console.Clear();
            Console.WriteLine("Thank you.");
            Console.WriteLine();
            Console.WriteLine("Your order is complete!");
        }

        public void Options()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("To return to the main menu, press: M");
            Console.WriteLine("To view your order history, press: O");
            Console.WriteLine("To exit, press: X");
            Console.ReadLine();
        }

    }
}
