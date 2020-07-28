using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaStore.Domain.Models;

namespace PizzaStore.Storing.Repository
{
  public class PizzaRepository
  {
    private PizzaStoreDbContext _db = new PizzaStoreDbContext();

    public void Insert(domain.Pizza pizza)
    {
      var newPizza = new Pizza();

      newPizza.Crust.CrustName = pizza.Crust;
      newPizza.Size.SizeName = pizza.Size;
      newPizza.PizzaName = pizza.Name;
      newPizza.PizzaPrice = pizza.Price;
      //newPizza.DateModified = DateTime.Now;
      //newPizza.Active = false;
      //newPizza.UserModified = Identity.Hash;

      _db.Pizza.Add(newPizza);
      _db.SaveChanges();
    }

    public List<domain.Pizza> ReadAll()
    {
      var domainPizzaList = new List<domain.Pizza>();

      foreach(var item in _db.Pizza.ToList())
      {
        domainPizzaList.Add(new domain.Pizza()
        {
          Name = item.PizzaName,
          Crust = item.Crust.CrustName,
          Size = item.Size.SizeName,
//          Toppings = new List<domain.Toppings>()
        });
      };

      return domainPizzaList;
    }

    public void Update() {}

    public void Delete() {}
  }
}
