using System;
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

      var starter = new Starter();
      var user = new User();
      var store = new Store();

      try
      {
        Menu(starter.CreateOrder(user, store));
      }
      catch (Exception ex)
      {
        System.Console.WriteLine(ex.Message);
      }
    }


    static void Menu(Order cart)
    {
      bool exit = false;
      // List<string> toppings = new List<string>();         // Ask for the type of pizza

      while (!exit)
      {
         List<string> toppings = new List<string>(); 
         string pizzaType = GetPizzaType(cart, toppings, ref exit);
        // System.Console.WriteLine($"Exited GetPizzaType with pizzaType = {pizzaType}");
        // if (exit) break;

        var pizzaSize = "";
        if (pizzaType != "")
        {
          pizzaSize = GetPizzaSize(cart, ref exit);                     // Ask for the size of pizza

          System.Console.WriteLine($"Pizza type is {pizzaType}, size = {pizzaSize}, toppings = {toppings}");
          // foreach (var t in toppings)
          // {
          //   System.Console.WriteLine(t + " ");
          // }

          cart.CreatePizza(pizzaSize, "Stuffed", toppings);   // add the pizza to the order

          System.Console.WriteLine($"We added a {pizzaSize} {pizzaType} pizza to your order");
        }

      }

      static void DisplayCart(Order cart)
      {
        foreach (var pizza in cart.Pizzas)
        {
          System.Console.WriteLine(pizza);
        }
      }

      static string GetPizzaType(Order cart, List<string> toppings, ref bool exit)
      {
        var exit1 = false;
        string typeSelected = "";
        var pizzaTypes = new string[] { "Cheese", "Pepperoni", "Hawaiian", "Custom" };

        do
        {

          Starter.PrintMenu();

          int selection;

          int.TryParse(Console.ReadLine(), out selection);

          switch (selection)
          {
            case 1: // Cheese
              toppings.Add("cheese");
              typeSelected = pizzaTypes[selection - 1];
              System.Console.WriteLine($"You chose {typeSelected}");
              break;
            case 2: // Pepperoni
              toppings.Add("cheese");
              toppings.Add("pepperoni");
              typeSelected = pizzaTypes[selection - 1];
              System.Console.WriteLine($"You chose {typeSelected}");
              break;
            case 3: // Hawaiian
              toppings.Add("cheese");
              toppings.Add("ham");
              toppings.Add("pineapple");
              typeSelected = pizzaTypes[selection - 1];
              System.Console.WriteLine($"You chose {typeSelected}");
              break;
            case 4: // Custom
              toppings.Add("none selected");
              typeSelected = pizzaTypes[selection - 1];
              System.Console.WriteLine($"You chose {typeSelected}");
              break;
            case 5:
              DisplayCart(cart);
              continue;
            case 6:
              var fmw = new FileManager();
              fmw.Write(cart);
              System.Console.WriteLine("Thank you for your order. Goodbye!");
              exit = true;
              break;
            default:
              break;
              // case 7:
              //   var fmr = new FileManager();
              //   DisplayCart(fmr.Read());
              //   continue;
          }
          System.Console.WriteLine();
          exit1 = true;
        } while (!exit1);

        return typeSelected;
      }

      static string GetPizzaSize(Order cart, ref bool exit)
      {
        var exit1 = false;
        var selection = 0;
        var sizeSelected = "";

        while (!exit && !exit1)
        {
          Starter.ChooseSize();

          int.TryParse(Console.ReadLine(), out selection);

          switch (selection)
          {
            case 1:
              sizeSelected = "Family";
              System.Console.WriteLine($"You chose {sizeSelected}");
              exit1 = true;
              break;
            case 2:
              sizeSelected = "Large";
              System.Console.WriteLine($"You chose {sizeSelected}");
              exit1 = true;
              break;
            case 3:
              sizeSelected = "Regular";
              System.Console.WriteLine($"You chose {sizeSelected}");
              exit1 = true;
              break;
            default:
              continue;
          }

        } 
        return sizeSelected;
      }
    }
  }
}
