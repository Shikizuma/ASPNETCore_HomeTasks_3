using Microsoft.AspNetCore.Mvc;

namespace Task4.Controllers
{
    public class JsonController : Controller
    {
        List<Client> clients = new List<Client>
        {
            new Client
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            },
            new Client
            {
                Id = 101,
                Login = "user2",
                Email = "user2@example.com"
            },
            new Client
            {
                Id = 102,
                Login = "user3",
                Email = "user3@example.com"
            }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientInfo()
        { 
            // Json - Серіалізує об'єкт переданий у параметрах JSON і повертає клієнту відповідь.
            return Json(clients);
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
