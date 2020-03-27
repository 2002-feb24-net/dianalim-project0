using System;
using TheGarden.DataAccess.Model;
using System.Linq;

namespace TheGarden.DataAccess
{
    public class CheckTables
    {
        public void CheckCustomer(string first_name)
        {

            using (var db = new LimsGardenContext())
            {

                var customerData = db.Customer
                .FirstOrDefault(p => p.FirstName == first_name);

                Console.WriteLine("The customer's last name  is: " + customerData.LastName);
            }
        }

        public void CheckOrder(string plant_name)
        {

            using (var db = new LimsGardenContext())
            {

                var plantData = db.Plant
                .FirstOrDefault(p => p. PlantName == plant_name);

                Console.WriteLine("There are " + plantData.InventoryCount + " left in stock.");
            }
        }
    }
}