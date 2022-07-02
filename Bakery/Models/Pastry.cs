using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int OrderQuantity { get; set; }
    public double Cost { get; set; }

    public Pastry(int orderQuantity, double cost)
    {
      OrderQuantity = orderQuantity;
      Cost = cost;
    }

    public double SetPastryOrder(int orderQuantity)
    {
      double convertOrderQuantity = Convert.ToDouble(orderQuantity);
      double pastryDiscount = Math.Floor(convertOrderQuantity/3);
      double pastryCost = 2;

      if (convertOrderQuantity >= 3)
      {
        double cost = Math.Ceiling(pastryDiscount * 5) + ((convertOrderQuantity % 3) * pastryCost);
        return cost;
      }
      else 
      {
        double cost = (pastryCost * convertOrderQuantity);
        return cost;
      }
    }
  }
}