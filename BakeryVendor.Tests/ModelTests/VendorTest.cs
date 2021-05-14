using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Tests
{
  [TestClass]
  public class VendorTests
  {
    private static string _vendorName = "";
    private static string _vendorDescription = "";

    private Vendor _newVendor = new Vendor(_vendorName);
    [TestMethod]
    public void Vendor_ShouldCreateVendorWithName_String()
    {
      Assert.AreEqual(_vendorName, _newVendor.Name);
    }

  }
}