using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoListII.Models;

namespace ToDoListII.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/items")]
        public ActionResult Index()
        {
          List<Item> allItems = Item.GetAll();
          return View(allItems);
        }

        [HttpGet("/items/new")]
        public ActionResult NewTaskForm()
        {
          return View();
        }

        [HttpPost("/items")]
        public ActionResult NewTask(string description)
        {
          Item newTask = new Item(description);
          return RedirectToAction("Index");
        }

    }
}
