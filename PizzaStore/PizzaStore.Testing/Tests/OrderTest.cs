using System.Collections.Generic;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing.Tests
{
  public class OrderTest
  {
    [Theory]
    [InlineData("Regular", "Crust", "T")]
    [InlineData("Family", "Crust", "T")]
    [InlineData("Large", "Crust", "T")]
    public void Test_CreatePizza(string s, string c, string t)
    {
      //arrange
      var sut = new Order();
      string size = s;
      string crust = c;
      List<string> toppings = new List<string> { t };

      //act
      sut.CreatePizza(size, crust, toppings);

      //assert
      Assert.True(sut.Pizzas.Count == 1);
    }
  }
}