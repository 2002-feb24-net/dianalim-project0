using System;


namespace TheGarden.Library
{
    public class Tree: PlantType
    {
        public void TreeOptions()
        {
             Console.Clear();
                Console.WriteLine("What kind of plant would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Loquat Tree $50");
                Console.WriteLine("Nectarine Tree $45");
                Console.WriteLine("Lemon Tree $30");
                Console.WriteLine("Rose Bush $15");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Loquat Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Nectarine Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Lemon Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Rose Bush")
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
