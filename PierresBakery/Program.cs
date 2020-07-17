using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      Console.Write("    ____  _                    _          ____        __                       _______\n   / __ \\(____  _____________ ( )_____   / __ )____ _/ /_____  _______  __    /       )\n  / /_/ / / _ \\/ ___/ ___/ _ \\|// ___/  / __  / __ `/ //_/ _ \\/ ___/ / / /   /_____   | ______\n / ____/ /  __/ /  / /  /  __/ (__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ /   (  '   ) / /    __\\   _____\n/_/   /_/\\___/_/  /_/   \\___/ /____/  /_____/\\__,_/_/|_|\\___/_/   \\__, /     |.  '| / |     \\ |  /     ))\n                                                                 /____/      |____|/  |`-----'  /_____))\n                                                                                       `-----'  `------'\n");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("Bread: $5 per loaf. Buy 2, Get 1 free!");
      Console.WriteLine("Pastry: $2 each. Get 3 for $5!");
      Console.WriteLine("How many bread loaves would you like to order?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to order?");
      int pastryOrder = int.Parse(Console.ReadLine());
      int breadCost = newBread.CalculateBreadCost(breadOrder);
      int pastryCost = newPastry.CalculatePastryCost(pastryOrder);
      Console.WriteLine("Your total is: $" + (breadCost + pastryCost));
    }
  }
}