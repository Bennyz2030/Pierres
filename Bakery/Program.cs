using System;
using Bakery;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public Bread bread;
    public Pastry pastry;
    public string error = "Something went wrong, please try again.";
    static void Main()
    {
      Program program = new Program();
      program.TopMenu();
    }

    public void TopMenu()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Would you like to order some bread? Type Y for yes, or N for no.");

      string menuChoice = Console.ReadLine().ToUpper();
      bread = new Bread (0,0);
      pastry = new Pastry (0,0);

      if (menuChoice == "Y")
      {
        BreadOrder();
      }
      else if (menuChoice == "N")
      {
        NextQuestion();
      }
      else
      {
        Console.WriteLine("That is not a valid response. Please try again.");
      }
    }

    public void BreadOrder()
    {
      Console.WriteLine("Bread is $5 a loaf. For every 2 loaves you buy, get a third for free!");
      Console.WriteLine("How many loaves would you like?");

      int orderQuantity = 0;
      string userInput = Console.ReadLine();
      // bool isNumeric = int.TryParse(userInput, out orderQuantity);
      try
      {
        orderQuantity += int.Parse(userInput);
        bread.Cost = bread.SetBreadOrder(orderQuantity);
        Console.WriteLine($"Your total for bread is ${bread.Cost}");
      }
      catch
      {
        Console.WriteLine($"'{userInput}' is an invalid input.");
      }
      NextQuestion();
    }

    public void NextQuestion()
      {
        Console.WriteLine("Would you like to order some pastries? Type Y for yes, or N for no.");
        string menuChoice = Console.ReadLine().ToUpper();

        if (menuChoice == "Y")
        {
          PastryOrder();
        }
        else if (menuChoice == "N")
        {
          FinalTotal();
        }
      }

    public void PastryOrder()
    {
      Console.WriteLine("Pastries are $2 each, or get 3 for $5!");
      Console.WriteLine("How many would you like?");

      int orderQuantity = 0;
      string userInput = Console.ReadLine();

      try
      {
        orderQuantity += int.Parse(userInput);
        pastry.Cost = pastry.SetPastryOrder(orderQuantity);
        Console.WriteLine($"Your pastry total is ${pastry.Cost}");
      }
      catch
      {
        Console.WriteLine($"'{userInput}' is an invalid input.");
      }
      FinalTotal();
    }

    public void FinalTotal()
    {
      double totalOutput = bread.Cost + pastry.Cost;
      Console.WriteLine($"Your total today is ${totalOutput}. Have an amazing day!");
    }
  }
}