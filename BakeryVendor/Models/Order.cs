using System.Collections.Generic;
namespace BakeryVendor.Models
{
  public class Order
  {
    public int OrderNumber { get; }

    public string Title { get; }
    private List<Order> _instances = new List<Order> { };
    public Order()
    {
      OrderNumber = _instances.Count;
    }
  }
}