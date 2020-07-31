using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
// using System.Data.Entity;
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
      newPizza.Qty = pizza.Qty;
      newPizza.PizzaPrice = pizza.Price;

      newPizza.PizzaTopping = new HashSet<PizzaTopping>();
      foreach (var t in pizza.Toppings)
      {
        var newTopping = new Topping();
        newTopping.ToppingName = t;
        newPizza.PizzaTopping.Add(new PizzaTopping {Topping = newTopping, Pizza = newPizza});
      };

      _db.Pizza.Add(newPizza);
      _db.SaveChanges();
    }

    public void CreateOrderDb(domain.Order order)
    {
      var newOrder = new Orders();
      newOrder.Store = new Stores();
      newOrder.User = new Users();

      newOrder.Store.StoreName = order.Store;
      newOrder.User.UserName = order.User;

      foreach (var p in order.Pizzas)
      {
        var newPizza = new Pizza();
        newPizza.PizzaName = p.Name;
        newPizza.Qty = p.Qty;
        newPizza.PizzaPrice = p.Price;
        newOrder.Pizza.Add(newPizza);
      }

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
      var query = _db.Pizza.Include(t => t.Crust).Include(t => t.Size);

      foreach (var item in query.ToList())
      // foreach (var item in query.ToList())
        
        domainPizzaList.Add(new domain.Pizza()
        {
          Name = item.PizzaName,
          // new Pizza.Crust() { CrustName = item.CrustName },
          Crust = item.Crust.CrustName,
          Size = item.Size.SizeName,
          Price = item.PizzaPrice,
          Qty = item.Qty
          //          Toppings = new List<domain.Toppings>()
        });

      return domainPizzaList;
    }
    public void Update() { }

    public void Delete() { }

  }


}

