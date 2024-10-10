using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class EventsController : Controller
    {
        public IActionResult Events()
        {
            return View();
        }
    }
}
