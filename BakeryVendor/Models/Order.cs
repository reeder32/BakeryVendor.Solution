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
    public double Price { get; set; } = 0.0;

    private static List<Order> _instances = new List<Order> { };
    public Order(string description, DateTime orderDate)
    {
      Description = description;
      OrderDate = orderDate.ToString();
      _instances.Add(this);
      OrderNumber = _instances.Count;
      Title = OrderNumber.ToString();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int orderNumber)
    {
      return _instances[orderNumber - 1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void GetPrice()
    {
      Random rando = new Random();
      Price = 1.5 * rando.Next(1, 10);
    }
  }
}