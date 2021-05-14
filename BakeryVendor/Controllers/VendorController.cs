using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BakeryVendor.Models;
namespace BakeryVendor.Controllers
{
  public class VendorController : Controller
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
  }
}