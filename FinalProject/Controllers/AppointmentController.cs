using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
