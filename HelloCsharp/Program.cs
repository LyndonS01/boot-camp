using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main()
        {
          Console.Write("Enter firstname: ")
          var firstName = Console.ReadLine();
          Console.Write("Enter lastname: ");
          string lastName = Console.ReadLine();

          Console.WriteLine(firstName + " " + lastName);
          Console.WriteLine("{0} {1}", firstName, lastName);
          Console.WriteLine($"{firstName} {lastName}";

          Console.ReadLine();
        }
    }
}
