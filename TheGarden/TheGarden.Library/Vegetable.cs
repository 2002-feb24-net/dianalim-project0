using System;


namespace TheGarden.Library
{
    public class Vegetable: PlantType
    {
        public void VegetableOptions()
        {
                Console.Clear();
                Console.WriteLine("What kind of vegetable would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Cucumber $3");
                Console.WriteLine("Asparagus $3");
                Console.WriteLine("Carrot $1");
                Console.WriteLine("Bell Pepper $2");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Cucumber")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Asparagus")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Carrot")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    var total = new TotalCost();
                    var total2 = total.Calculate(fruitChoice, Convert.ToInt32(amount));
                    Console.WriteLine("Your total is: $" + total2);
                    Console.ReadLine();
                }
                else if(fruitChoice == "Bell Pepper")
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