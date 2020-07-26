using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Stores
  {
    public static void Menu()
    {
      bool exit = false;

      while (!exit)
      {
        do
        {

          Starter.MgmtMenu();

          int selection;

          int.TryParse(Console.ReadLine(), out selection);

          switch (selection)
          {
            case 1: // Sales History
              break;
            case 2: // Order History
              break;
            default:
              exit = true;
              break;
          }

          System.Console.WriteLine();

        } while (!exit);

      }

    }
  }
}
