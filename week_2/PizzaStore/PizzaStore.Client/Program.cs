﻿using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      // TestDbConnection();
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld");
      System.Console.WriteLine("Best Pizza in the World");
      System.Console.WriteLine();

      System.Console.WriteLine("Select 1 for Client Orders");
      System.Console.WriteLine("Select 2 for Store Management");
      System.Console.WriteLine("Press any other key to exit");
      System.Console.WriteLine();

      int selection;
      int.TryParse(Console.ReadLine(), out selection);

      var starter = new Starter();      // creates a new Order object
      var user = new User();
      var store = new Store();
      
      switch (selection)
      {
        case 1:

          try
          {
            Client.Menu(starter.CreateOrder(user, store));  // creates User and Store objects containing one Order object each
          }
          catch (Exception ex)
          {
            System.Console.WriteLine(ex.Message);
          }

                    
          break;
        case 2:

          try
          {
            Stores.Menu();
          }
          catch (Exception ex)
          {
            System.Console.WriteLine(ex.Message);
          }
                  
          break;
        default:
          break;
      }

    }

    static void TestDbConnection()
    {
      var db = new PizzaStoreDbContext();

      foreach (var p in db.Pizza)
      {
        System.Console.WriteLine(p.PizzaName);
      }
    }
  }
}
