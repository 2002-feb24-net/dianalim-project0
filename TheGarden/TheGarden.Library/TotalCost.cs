using System;
using TheGarden.DataAccess.Model;
using System.Linq;

namespace TheGarden.Library
{
    public class TotalCost
    {
        public double Calculate(string product, int quantity)
        {
            using (var db = new LimsGardenContext())
            {
                var plantData = db.Plant
                .FirstOrDefault(p => p.PlantName == product);
                plantData.InventoryCount = (plantData.InventoryCount - quantity);
                return (double)(plantData.Cost * quantity);
            
            }
        }
    }
}