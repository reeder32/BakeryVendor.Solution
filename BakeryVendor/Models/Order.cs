using System.Collections.Generic;
using System.Globalization;
using System;
namespace BakeryVendor.Models
{
  public class Order
  {
    public int OrderNumber { get; }

    public string Title { get; }
    public string Description { get; set; }

    public string OrderDate { get; set; }
    private List<Order> _instances = new List<Order> { };
    public Order(string description, DateTime orderDate)
    {
      Description = description;
      OrderNumber = _instances.Count;
      Title = OrderNumber.ToString();
      OrderDate = orderDate.ToString();
    }

    public static List<Order> GetAll()
    {
      return new List<Order> { };
    }
  }
}