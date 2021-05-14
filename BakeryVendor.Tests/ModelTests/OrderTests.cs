using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class OrderTests
  {
    private static string _orderDescription = "12 loaves of bread";
    private Order _newOrder = new Order(_orderDescription, DateTime.Now);
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

    [TestMethod]

    public void Order_ShouldCreateOrderWithDate_String()
    {
      string expectedDate = DateTime.Now.ToString();
      Console.WriteLine(expectedDate);
      Assert.AreEqual(_newOrder.OrderDate, expectedDate);
    }
  }
}