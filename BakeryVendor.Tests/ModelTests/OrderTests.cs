using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class OrderTests
  {
    private Order _newOrder = new Order();
    [TestMethod]

    public void Order_ShouldCreateOrderWithOrderNumber_Int()
    {


      Assert.AreEqual(_newOrder.OrderNumber, 0);
    }

    [TestMethod]

    public void Order_ShouldCreateOrderWithTitle_String()
    {
      Assert.AreEqual(_newOrder.Title, "0");
    }

    [TestMethod]

    public void Order_ShouldCreateOrderWithDescription_String()
    {
      Assert.AreEqual(_newOrder.Description, "12 loaves of bread");
    }
  }
}