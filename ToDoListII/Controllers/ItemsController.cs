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
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string description)
        {
          Item newTask = new Item(description);
          return RedirectToAction("Index");
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int id)
        {
          Item item = Item.Find(id);
          return View(item);
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
          Item.ClearAll();
          return View();
        }

    }
}
