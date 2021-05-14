using System.Collections.Generic;

namespace BakeryVendor.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    private List<Order> _orders = new List<Order> { };

    public Vendor(string name)
    {
      Name = name;
    }
  }
}