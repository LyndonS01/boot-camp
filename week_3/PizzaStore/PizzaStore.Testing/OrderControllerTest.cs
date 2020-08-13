using PizzaStore.Client.Controllers;
using PizzaStore.Storing;

namespace PizzaStore.Testing
{
   [TestClass]
   public class OrderControllerTest
   {
	
      [TestMethod]
      public void OrderController.Post(PizzaStoreDbContext dbContext, int id)
      {
         // Arrange
         OrderController controller = new OrderController();
         // Act
         ViewResult result = controller.Post() as ViewResult;
         // Assert
         Assert.IsNotNull(result);
      }
		
      [TestMethod]
      public void About(){
         // Arrange
         HomeController controller = new HomeController();
         // Act
         ViewResult result = controller.About() as ViewResult;
         // Assert
         Assert.AreEqual("Your application description page.", result.ViewBag.Message);
      }
		
      [TestMethod]
      public void Contact(){
         // Arrange
         HomeController controller = new HomeController();
         // Act
         ViewResult result = controller.Contact() as ViewResult;
         // Assert
         Assert.IsNotNull(result);
      }
   }
}