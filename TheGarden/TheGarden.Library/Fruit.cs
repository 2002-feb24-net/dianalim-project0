using System;

namespace TheGarden.Library
{
    public class Fruit: PlantType 
    {
        public void FruitOptions()
        {
                Console.Clear();
                Console.WriteLine("What kind of fruit would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Watermelon $6");
                Console.WriteLine("Nectarine $5");
                Console.WriteLine("Loquat $2");
                Console.WriteLine("Asian Apple $3");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Watermelon")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Nectarine")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Loquat")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Asian Apple")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error: Please check item name spelling, and try again.");
                    // Create a way to return to beginning of fruit prompt
                }
        }
        
    }
}