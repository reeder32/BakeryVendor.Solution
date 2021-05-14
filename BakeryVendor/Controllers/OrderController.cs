using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;
namespace BakeryVendor.Controllers
{
  public class Order : Controller
  {

    [HttpGet("vendors/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/order")]
    public ActionResult Create(string description)
    {

      return View();
    }

  }
}