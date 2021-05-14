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
    private static DateTime _orderDate = DateTime.Now;
    private Order _newOrder = new Order(_orderDescription, _orderDate);
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

      Assert.AreEqual(_newOrder.OrderDate, expectedDate);
    }

    [TestMethod]

    public void Order_ShouldAddOrderToInstances_ArrayOfOrders()
    {
      Order secondOrder = new Order(_orderDescription, _orderDate);
      List<Order> expectedOrder = new List<Order> { _newOrder, secondOrder };

      List<Order> resultOrder = Order.GetAll();

      CollectionAssert.AreEqual(expectedOrder, resultOrder);
    }
  }
}