using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  public class Starter
  {
    public Order CreateOrder(User user, Store store)
    {
      try
      {
        var order = new Order();

        user.Orders.Add(order);
        store.Orders.Add(order);

        return order;
      }
      catch
      {
        //return null;
        throw new System.Exception("we messed up");
      }
      finally
      {
        GC.Collect();
      }
    }

    public static void PrintMenu()
    {
      System.Console.WriteLine("Select 1 for Cheese Pizza");
      System.Console.WriteLine("Select 2 for Pepperoni Pizza");
      System.Console.WriteLine("Select 3 for Hawaiian Pizza");
      System.Console.WriteLine("Select 4 for Custom Pizza");
      System.Console.WriteLine("Select 5 for Show Cart");
      System.Console.WriteLine("Select 6 to  Save your Order & Exit");
      System.Console.WriteLine("Select 7 to  Show Previously Saved Orders");
      System.Console.WriteLine();
    }
    
    public static void ChooseSize()
    {
      System.Console.WriteLine("Select 1 for Family");
      System.Console.WriteLine("Select 2 for Large");
      System.Console.WriteLine("Select 3 for Regular");
      System.Console.WriteLine();
    }
        public static void MgmtMenu()
    {
      System.Console.WriteLine("Select 1 for Sales History");
      System.Console.WriteLine("Select 2 for Order History");
      System.Console.WriteLine("Press any other key to exit");
      System.Console.WriteLine();
    }
  }
}