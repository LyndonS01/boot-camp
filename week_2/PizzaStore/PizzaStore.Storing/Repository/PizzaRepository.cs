using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repository
{
  public class PizzaRepository
  {
    private PizzaStoreDbContext _db = new PizzaStoreDbContext();

    public void Create(domain.Pizza pizza)
    {
      var newPizza = new Pizza();

      newPizza.Crust = new Crust();
      newPizza.Size = new Size();

      newPizza.Crust.CrustName = pizza.Crust;
      newPizza.Size.SizeName = pizza.Size;
      newPizza.PizzaName = pizza.Name;
      newPizza.PizzaPrice = pizza.Price;

      _db.Pizza.Add(newPizza);
      _db.SaveChanges();
    }

    public void CreateOrderDb(domain.Order order)
    {
      var newOrder = new Orders();

      _db.Orders.Add(newOrder);
      _db.SaveChanges();
    }

    // public void CreateOrderDb(domain.Order order)
    // {
    //   var newOrder = new domain.Order();

    //   newOrder.Pizzas = order.Pizzas;

    //   _db.Orders.Add(newOrder);
    //   _db.SaveChanges();
    // }

    public List<domain.Pizza> ReadAll()
    {
      var domainPizzaList = new List<domain.Pizza>();

      foreach (var item in _db.Pizza.ToList())
        domainPizzaList.Add(new domain.Pizza()
        {
          Name = item.PizzaName,
          // Crust = item.Crust.CrustName,
          // Size = item.Size.SizeName,
          Price = item.PizzaPrice
          //          Toppings = new List<domain.Toppings>()
        });

      return domainPizzaList;
    }
    public void Update() { }

    public void Delete() { }

  }


}

