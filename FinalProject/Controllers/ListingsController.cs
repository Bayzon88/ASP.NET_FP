using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ListingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
