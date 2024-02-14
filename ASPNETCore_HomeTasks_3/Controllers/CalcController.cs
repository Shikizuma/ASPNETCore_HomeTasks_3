using ASPNETCore_HomeTasks_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_HomeTasks_3.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(decimal number1, decimal number2, string operation)
        {
            decimal result;

            switch (operation)
            {
                case "add":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        ViewBag.Message = "Division by zero is not allowed";
                        return View("Index");
                    }
                    break;
                default:
                    ViewBag.Message = "Invalid operation";
                    return View("Index");
            }

            ViewBag.Result = result;
            return View("Index");
        }
    }
}
