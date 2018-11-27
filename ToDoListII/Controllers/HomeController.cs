using Microsoft.AspNetCore.Mvc;

namespace ToDoListII.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
