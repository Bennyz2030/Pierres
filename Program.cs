using System;
using Bakery;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public Bread bread;
    public Pastry pastry;
    static void Main()
    {

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
         breadOrder();
       }
    }

    public class BreadOrder()
    {
     public void BreadOrder()
    {
      Console.WriteLine("Bread is $5 a loaf. For every 2 loaves you buy, get a third for free!");
      Console.WriteLine("How many loaves would you like?");

      int orderQuantity = 0;
      string userInput = Console.ReadLine();
    }
    TopMenu();
  }

  public NextQuestion()
  {
    Console.WriteLine("Would you like to order some pastries? Type Y for Yes, or N for No")
    strint menuChoice = Console.ReadLine().ToUpper();
    TopMenu();
  }
}