﻿using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld");
      System.Console.WriteLine("Best Pizza in the World");
      System.Console.WriteLine();

      // array
      //1-dimensional
      string[] cart1 = { "", "", "" }; // initial values
      string[] cart2 = new string[3]; // default values
      string[] cart3 = new[] { "", "", "" }; // initial values - custom datatypes or earlier C# versions

      // list
      List<string> cart4 = new List<string>{"", "", ""}; // initial values
      List<string> cart5 = new List<string>(); // default values
      List<Pizza> cart6 = new List<Pizza>();

      //Menu(cart2);
      Menu2(cart6);
    }

    static void Menu(string[] cart)
    {
      var exit = false;
      var number = 0;

      
      
      do
      {
        if (number < cart.Length)
        {
          
          System.Console.WriteLine("Select 1 for Cheese Pizza");
          System.Console.WriteLine("Select 2 for Pepperoni Pizza");
          System.Console.WriteLine("Select 3 for Pineapple Pizza");
          System.Console.WriteLine("Select 4 for Custom Pizza");
          System.Console.WriteLine("Select 5 for Show Cart");
          System.Console.WriteLine("Select 6 for Exit");
          System.Console.WriteLine();

          int select;

          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart[number] = "cheese";
              number += 1;
              System.Console.WriteLine("added Cheese");
              break;
            case 2:
              cart[number] = "pepperoni";
              number += 1;
              System.Console.WriteLine("added Pepperoni");
              break;
            case 3:
              cart[number] = "pineapple";
              number += 1;
              System.Console.WriteLine("added Pineapple");
              break;
            case 4:
              cart[number] = "custom";
              number += 1;
              System.Console.WriteLine("added Custom");
              break;
            case 5:
              DisplayCart(cart);
              break;
            case 6:
              System.Console.WriteLine("thank you, goodbye!");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart(cart);
          exit = true;
        }
      } while (!exit);
    }

    static void Menu2(List<Pizza> cart)
    {
      var exit = false;
      var number = 0;
      var startup = new PizzaStore.Client.Startup();

      do
      {
        if (number < 10)
        {
          System.Console.WriteLine("Select 1 for Cheese Pizza");
          System.Console.WriteLine("Select 2 for Pepperoni Pizza");
          System.Console.WriteLine("Select 3 for Pineapple Pizza");
          System.Console.WriteLine("Select 4 for Custom Pizza");
          System.Console.WriteLine("Select 5 for Show Cart");
          System.Console.WriteLine("Select 6 for Exit");
          System.Console.WriteLine();

          int select;

          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"cheese"}));
              number += 1;
              System.Console.WriteLine("added Cheese");
              break;
            case 2:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pepperoni"}));
              number += 1;
              System.Console.WriteLine("added Pepperoni");
              break;
            case 3:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"pineapple"}));
              number += 1;
              System.Console.WriteLine("added Pineapple");
              break;
            case 4:
              cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"custom"}));
              number += 1;
              System.Console.WriteLine("added Custom");
              break;
            case 5:
              DisplayCart2(cart);
              break;
            case 6:
              System.Console.WriteLine("thank you, goodbye!");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart2(cart);
          exit = true;
        }

        System.Console.WriteLine();
      } while (!exit);
    }

    static void DisplayCart(string[] cart)
    {
      foreach(var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }

    static void DisplayCart2(List<Pizza> cart)
    {
      foreach(var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }
    }
  }
}