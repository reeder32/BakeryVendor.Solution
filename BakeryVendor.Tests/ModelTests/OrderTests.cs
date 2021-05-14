using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]

    public void Order_ShouldCreateOrderWithTitle_String()
    {
      Order newOrder = new Order();
      newOrder.OrderNumber = 1;
      Assert.AreEqual(newOrder.OrderNumber, 1);
    }
  }
}