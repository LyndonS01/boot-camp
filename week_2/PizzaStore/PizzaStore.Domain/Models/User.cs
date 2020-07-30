using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class User
  {
    public string UserName { get; set; }
    public List<Order> Orders { get; set; }

    public User()
    {
      Orders = new List<Order>();
    }
  }
}