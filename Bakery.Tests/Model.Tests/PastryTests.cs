using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void SetProperties_PastryConstructorSetsProperties_IntDouble()
    {
      int orderQuantity = 1;
      double cost = 2;
      Pastry newPastry = new Pastry(orderQuantity, cost);
      int totalUserOrder = newPastry.OrderQuantity;
      double totalCost = newPastry.Cost;
      Assert.AreEqual(totalUserOrder, newPastry.OrderQuantity);
      Assert.AreEqual(totalCost, newPastry.Cost);
    }
  }
}