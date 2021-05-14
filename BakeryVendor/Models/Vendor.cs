using System.Collections.Generic;

namespace BakeryVendor.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders = new List<Order> { };

    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}