using System.Collections.Generic;
namespace BakeryVendor.Models
{
  public class Order
  {
    public int OrderNumber { get; }
    private List<Order> _instances = new List<Order> { };
    public Order()
    {
      OrderNumber = _instances.Count;
    }
  }
}