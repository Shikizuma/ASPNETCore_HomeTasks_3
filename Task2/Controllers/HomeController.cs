using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Adress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.Browser = Request.Headers["User-Agent"];
            return View();
        }
    }
}
