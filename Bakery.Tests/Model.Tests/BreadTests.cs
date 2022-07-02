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

    [TestMethod]
      public void SetBreadOrder_CalculateUserOrderWithoutDiscount_Int()
    {
      int orderQuantity = 2;
      double cost = 10;
      Bread newBread = new Bread(orderQuantity, cost);
      int totalUserOrder = newBread.OrderQuantity;
      double totalCost = newBread.Cost;
      Assert.AreEqual(totalUserOrder, newBread.OrderQuantity);
      Assert.AreEqual(totalCost, 10);
    }

    [TestMethod]
    public void SetBreadOrder_CalculateUserOrderWithDiscount_Double()
    {
      int orderQuantity = 6;
      double cost = 20;
      Bread newBread = new Bread(orderQuantity, cost);
      int totalUserOrder = newBread.OrderQuantity;
      double totalCost = newBread.Cost;
      Assert.AreEqual(totalUserOrder, newBread.OrderQuantity);
      Assert.AreEqual(totalCost, 20);
    }
  }
}