using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class Store
  {
    public string StoreName { get; set; }
    public List<Order> Orders { get; set; }

    public Store()
    {
      Orders = new List<Order>();
    }
  }
}