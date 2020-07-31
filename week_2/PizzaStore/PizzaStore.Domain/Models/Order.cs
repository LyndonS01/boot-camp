using System.Collections.Generic;
// using PizzaStore.Storing;
// using System.Linq;

// using domain = PizzaStore.Storing.Repositories.PizzaRepository;

namespace PizzaStore.Domain.Models
{
  public class Order
  {
    public string Store { get; set; }
    public string User { get; set; }
    public List<Pizza> Pizzas { get; set; }

    public void CreatePizza(string name, string size, string crust, List<string> toppings, int qty, decimal price)
    {
      
      Pizzas.Add(new Pizza(name, size, crust, toppings, qty, price));
    }

    public Order()
    {
      Store = "";
      User = "";
      Pizzas = new List<Pizza>();
    }
    public Order(string storename, string username)
    {
      // Store = storename;
      // User = username;
      Store = "Location B";
      User = "lyndons";
      Pizzas = new List<Pizza>();
    }

  }
}