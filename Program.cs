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
    }
  }
}