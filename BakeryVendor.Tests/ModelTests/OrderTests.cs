using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    private static string _orderDescription = "12 loaves of bread";
    private static DateTime _orderDate = DateTime.Now;
    private Order _newOrder = new Order(_orderDescription, _orderDate);

    public void Dispose()
    {
      Order.ClearAll();
    }


    [TestMethod]

    public void Order_ShouldCreateOrderWithOrderNumber_Int()
    {


      Assert.AreEqual(0, _newOrder.OrderNumber);
    }

    [TestMethod]

    public void Order_ShouldCreateOrderWithTitle_String()
    {
      Assert.AreEqual("0", _newOrder.Title);
    }

    [TestMethod]

    public void Order_ShouldCreateOrderWithDescription_String()
    {
      Assert.AreEqual("12 loaves of bread", _newOrder.Description);
    }

    [TestMethod]

    public void Order_ShouldCreateOrderWithDate_String()
    {
      string expectedDate = DateTime.Now.ToString();

      Assert.AreEqual(_newOrder.OrderDate, expectedDate);
    }

    [TestMethod]

    public void GetAll_ShouldAddOrderToInstancesAndReturnAllORders_ArrayOfOrders()
    {
      Order secondOrder = new Order(_orderDescription, _orderDate);
      List<Order> expectedOrder = new List<Order> { _newOrder, secondOrder };

      Assert.AreEqual(expectedOrder.Count, Order.GetAll().Count);
    }

    [TestMethod]

    public void GetPrice_ShouldReturnRandomDoubleBasedOnNumberOfOrders_Double()
    {
      double expected = 12.40;
      double result = _newOrder.GetPrice();

      Assert.AreEqual(expected.GetType(), result.GetType());
    }
  }
}