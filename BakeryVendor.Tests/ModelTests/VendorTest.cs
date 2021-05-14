using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class VendorTests
  {
    private static string _vendorName = "Delila's Bakery";
    private static string _vendorDescription = "A Sweet place to eat";

    private Vendor _newVendor = new Vendor(_vendorName, _vendorDescription);
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

  }
}