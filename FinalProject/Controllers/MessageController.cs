using Microsoft.AspNetCore.Mvc;
using FinalProject.Models.Messages;

namespace FinalProject.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            List<Message> messages = new List<Message>();
            DateTime dt = DateTime.Now;
            Message message1 = new Message(1, 1, 2, dt, "This is a first message");
			Message message2 = new Message(2, 1, 2, dt, "This is a second message");
			messages.Add(message1);
			messages.Add(message2);
            ViewBag.Messages = messages;
            return View(messages);
        }

        public IActionResult Details()
        {
            return View();  
        }
    }
}
