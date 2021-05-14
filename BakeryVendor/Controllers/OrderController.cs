using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BakeryVendor.Models;
using System;

namespace BakeryVendor.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("vendors/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("vendors/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Dictionary<string, object> dict = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      dict.Add("vendor", vendor);
      dict.Add("order", order);
      return View(dict);
    }


    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string description)
    {
      Dictionary<string, object> dict = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(description, DateTime.Now);
      newOrder.GetPrice();
      foundVendor.AddOrder(newOrder);
      dict.Add("order", newOrder);
      dict.Add("vendor", foundVendor);
      return View("Show", dict);
    }

  }
}

// Dictionary<string, object> model = new Dictionary<string, object>();
// Category foundCategory = Category.Find(categoryId);
// Item newItem = new Item(itemDescription);
// foundCategory.AddItem(newItem);
// List<Item> categoryItems = foundCategory.Items;
// model.Add("items", categoryItems);
// model.Add("category", foundCategory);
// return View("Show", model);