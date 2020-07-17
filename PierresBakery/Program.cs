using PierresBakery.Models;
using System;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      //Initialize new instances of Bread and Pastry classes
      
      Pastry newPastry = new Pastry();

      //Welcome message
      Console.Write("    ____  _                    _          ____        __                       _______\n   / __ \\(____  _____________ ( )_____   / __ )____ _/ /_____  _______  __    /       )\n  / /_/ / / _ \\/ ___/ ___/ _ \\|// ___/  / __  / __ `/ //_/ _ \\/ ___/ / / /   /_____   | ______\n / ____/ /  __/ /  / /  /  __/ (__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ /   (  '   ) / /    __\\   _____\n/_/   /_/\\___/_/  /_/   \\___/ /____/  /_____/\\__,_/_/|_|\\___/_/   \\__, /     |.  '| / |     \\ |  /     ))\n                                                                 /____/      |____|/  |`-----'  /_____))\n                                                                                       `-----'  `------'\n");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("Bread: $5 per loaf. Buy 2, Get 1 free!");
      Console.WriteLine("Pastry: $2 each. Get 3 for $5!");

      //Get user input for bread order
      Console.WriteLine("How many bread loaves would you like to order?");
      //Check if users input can be converted to an int, if not prompt user to try again until there is a valid input
      //Valid input: int >= 0
      bool breadOrderSuccess = int.TryParse(Console.ReadLine(), out int breadOrder);
      while((breadOrderSuccess == false) || (breadOrder < 0))
      {
        Console.WriteLine("That is not a valid input. Please enter the number of bread loaves you would like. Enter 0 if you do not want any bread loaves.");
        breadOrderSuccess = int.TryParse(Console.ReadLine(), out breadOrder);
      }
      
      //Get user input for pastry order
      Console.WriteLine("How many pastries would you like to order?");
      //Check if users input can be converted to an int, if not prompt user to try again until there is a valid input
      //Valid input: int >= 0
      bool pastryOrderSuccess = int.TryParse(Console.ReadLine(), out int pastryOrder);
      while(!pastryOrderSuccess || (pastryOrder < 0))
      {
        Console.WriteLine("That is not a valid input. Please enter the number of pastries you would like. Enter 0 if you do not want any pastries.");
        pastryOrderSuccess = int.TryParse(Console.ReadLine(), out pastryOrder);
      }

      //Calculate costs of bread and pastry orders and output total to user
      Bread newBread = new Bread(breadOrder);
      newBread.CalculateBreadCost();
      int breadCost = newBread.Cost;
      int pastryCost = newPastry.CalculatePastryCost(pastryOrder);
      Console.WriteLine("Your total is: $" + (breadCost + pastryCost));
    }
  }
}