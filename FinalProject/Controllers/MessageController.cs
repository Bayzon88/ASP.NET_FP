using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
