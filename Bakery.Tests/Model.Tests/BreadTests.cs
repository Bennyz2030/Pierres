using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void SetProperties_BreadConstuctorSetsProperties_IntDouble()
    {
      int orderQuantity = 1;
      double cost = 5;

      Bread newBread = new Bread(orderQuantity, cost);
      int totalUserOrder = newBread.OrderQuantity;
      double totalCost = newBread.Cost;
      Assert.AreEqual(totalUserOrder, newBread.OrderQuantity);
      Assert.AreEqual(totalCost, newBread.Cost);
    }
    
  }
}