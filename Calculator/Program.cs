using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Basic Calculator");
            var stay = true;

            do {
            Console.WriteLine("Menu");
            System.Console.WriteLine("Press 1 for Addition");
            System.Console.WriteLine("Press 2 for Subtraction");
            System.Console.WriteLine("Press 3 for Multiplication");
            System.Console.WriteLine("Press 4 for Division");
            System.Console.WriteLine("Press 5 to Exit");

            var choice = Console.ReadLine();

            switch(choice)
            {
              case "1": 
                // var input1 = (double) Console.ReadLine();
                // var input2 = Console.ReadLine() as double;

                var input1 = double.Parse(Console.ReadLine());
                double input2;
                double.TryParse(Console.ReadLine(), out input2);
                Add(input1, input2);
                break;

              case "3": 

                double input3, input4;
                double.TryParse(Console.ReadLine(), out input3);
                double.TryParse(Console.ReadLine(), out input4);
                Multiply(input3, input4);
                break;
              
              default:
                stay = false;
                break;
            }
          } while (stay);
        }

        static void Add(double op1, double op2)
        {
          var sum = op1 + op2;
          System.Console.WriteLine($"Your answer is: {sum}");
        }
        static void Multiply(double op1, double op2)
        {
          var product = op1 * op2;
          System.Console.WriteLine($"Your answer is: {product}");
        }
        
         
    }
}
