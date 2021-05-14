using System.Collections.Generic;
namespace BakeryVendor.Models
{
  public class Order
  {
    public int OrderNumber { get; }

    public string Title { get; }
    public string Description { get; set; }
    private List<Order> _instances = new List<Order> { };
    public Order()
    {
      OrderNumber = _instances.Count;
      Title = OrderNumber.ToString();
    }
  }
}