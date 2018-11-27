using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListII.Controllers;
using ToDoListII.Models;

namespace ToDoListII.Tests
{
  [TestClass]
  public class ItemsControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      ItemsController controller = new ItemsController();

      //Act
      IActionResult view = controller.NewTask("Walk the dog");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      ItemsController controller = new ItemsController();
      RedirectToActionResult actionResult = controller.NewTask("Walk the dog") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
