using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    private static string _vendorName = "Delila's Bakery";
    private static string _vendorDescription = "A Sweet place to eat";
    private Vendor _newVendor = new Vendor(_vendorName, _vendorDescription);

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Vendor_ShouldCreateVendorWithName_String()
    {
      Assert.AreEqual(_vendorName, _newVendor.Name);
    }

    [TestMethod]
    public void Vendor_ShouldCreateVendorWithDescription_String()
    {
      Assert.AreEqual(_vendorDescription, _newVendor.Description);
    }

    [TestMethod]
    public void Vendor_ShouldReturnCountOrInstances_Int()
    {
      Vendor newVendor = new Vendor("name", "description");

      Assert.AreEqual(2, Vendor.GetAll().Count);
    }

    [TestMethod]
    public void Vendor_ShouldReturnId_Int()
    {
      int vendorId = Vendor.GetAll().Count;

      Assert.AreEqual(vendorId, _newVendor.Id);
    }

    [TestMethod]
    public void AddItem_ShouldAddNewOrderToListOfOrders_ArrayOfItems()
    {
      Order newOrder = new Order("description", DateTime.Now);
      _newVendor.AddOrder(newOrder);
      List<Order> expected = new List<Order> { newOrder };
      CollectionAssert.AreEqual(expected, _newVendor.Orders);
    }

    [TestMethod]
    public void Find_ShouldBeAbleToFindVendorWithId_Vendor()
    {
      Vendor foundVendor = Vendor.Find(_newVendor.Id);
      Assert.AreEqual(foundVendor, _newVendor);
    }
  }
}