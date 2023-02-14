using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
