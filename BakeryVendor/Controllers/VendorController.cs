using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;
namespace BakeryVendor.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetAll();
      return View(vendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }

    // [HttpGet("/{vendorId}/orders/new")]
    // public ActionResult New(int vendorId)
    // {
    //   Vendor vendor = Vendor.Find(vendorId);
    //   return View(vendor);
    // }
  }
}