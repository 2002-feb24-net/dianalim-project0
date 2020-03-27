using System;

namespace TheGarden.Library 
{
    public abstract class PlantType  
    {
        public virtual string plant_name { get; set; }
        public virtual int inventoryCount { get; set; }
        public virtual int cost { get; set;}
    }
}