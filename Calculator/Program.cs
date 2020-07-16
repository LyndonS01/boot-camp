using System;

namespace Calculator
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to our Basic Calculator");
      bool stay = true;

      while(stay)
      {
        Console.WriteLine("Menu");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        Console.WriteLine("Press 5 to Exit");
        string choice = Console.ReadLine();

        switch(choice)
        {
          case "1":
          case "2":
          case "3":
          case "4":
            break;

          default:
            stay = false;
            continue;
        }

        Console.WriteLine("Enter 1st operand");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter 2nd operand");
        string input2 = Console.ReadLine();

        double operand1, operand2, result;
        double.TryParse(input1, out operand1);
        double.TryParse(input2, out operand2);

        result = compute(choice, operand1, operand2);
        Console.WriteLine($"The answer is: {result}\n");
        
      }

      static double compute(string choice, double operand1, double operand2)
      {
        switch(choice)
        {
          case "1": 
            return (operand1 + operand2);

          case "2": 
            return (operand1 - operand2);

          case "3": 
            return (operand1 * operand2);
          
          case "4": 
            return (operand1 / operand2);
            
          default:
            return (0);
        }
      } 
    }
  }
} 

