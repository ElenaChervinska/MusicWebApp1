using Microsoft.AspNetCore.Mvc;

namespace MusicWebApp1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Message"] = "Hello World!";
        return View("Index");
    }
}
