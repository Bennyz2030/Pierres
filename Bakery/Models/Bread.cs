using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int OrderQuantity { get; set; }
    public double Cost { get; set; }
    
    public Bread(int orderQuantity, double cost)
      {
        OrderQuantity = orderQuantity;
        Cost = cost;
      }
    public double SetBreadOrder(int orderQuantity)
    {
      double convertedUserOrder = Convert.ToDouble(orderQuantity);
      double thirdFree = convertedUserOrder/3;
      double breadCost = 5;

      if (convertedUserOrder % 3 == 0)
      {
        double cost = (breadCost * convertedUserOrder) - (breadCost * thirdFree);
        return cost;
      }
      else if (convertedUserOrder < 3)
      {
        double cost = (breadCost * convertedUserOrder);
        return cost;
      }
      else
      {
        double cost = (breadCost * convertedUserOrder) - breadCost;
        return cost;      
      }
    }
  }
}