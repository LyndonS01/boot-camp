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
            Environment.Exit(0);
            break;
        }

        Console.WriteLine("Enter 1st operand");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter 2nd operand");
        string input2 = Console.ReadLine();

        double operand1, operand2;
        double.TryParse(input1, out operand1);
        double.TryParse(input2, out operand2);
        compute(choice, operand1, operand2, stay);
        
      }

      static void compute(string choice, double operand1, double operand2, bool stay)
      {
        switch(choice)
        {
          case "1": 
            var sum = operand1 + operand2;
            Console.WriteLine($"Your answer is: {sum}\n");
            break;

          case "2": 
            var diff = operand1 - operand2;
            Console.WriteLine($"Your answer is: {diff}\n");
            break;

          case "3": 
            var prod = operand1 * operand2;
            Console.WriteLine($"Your answer is: {prod}\n");
            break;
          
          case "4": 
            var div = operand1 / operand2;
            Console.WriteLine($"Your answer is: {div}\n");
            break;
            
          default:
            stay = false;
            break;
        }
      } 
    }
  }
} 

