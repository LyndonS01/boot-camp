using System.Collections.Generic;
// using PizzaStore.Storing;
// using System.Linq;

// using domain = PizzaStore.Storing.Repositories.PizzaRepository;

namespace PizzaStore.Domain.Models
{
  public class Order
  {
    public List<Pizza> Pizzas { get; }

    public void CreatePizza(string name, string size, string crust, List<string> toppings, decimal price)
    {
      
      
      Pizzas.Add(new Pizza(name, size, crust, toppings, price));
    }

    public void CreateOrder(Order order)
    {
      // foreach (var p in order)
      // {
      //   PizzaRepository.Insert(p);
      // }
    }

    // private PizzaStore.Storing.PizzaStoreDbContext _db = new PizzaStore.Storing.PizzaStoreDbContext();
    // static void InsertPizzaDb(Pizza pizza)
    // {
    //   var newPizza = new Pizza();

    //   newPizza.Crust.CrustName = pizza.Crust;
    //   newPizza.Size.SizeName = pizza.Size;
    //   newPizza.PizzaName = pizza.Name;
    //   newPizza.PizzaPrice = pizza.Price;
    //   //newPizza.DateModified = DateTime.Now;
    //   //newPizza.Active = false;
    //   //newPizza.UserModified = Identity.Hash;

    //   _db.Pizza.Add(newPizza);
    //   _db.SaveChanges();
    // }
    public Order()
    {
      Pizzas = new List<Pizza>();
    }
  }
}