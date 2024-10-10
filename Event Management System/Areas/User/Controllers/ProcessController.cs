using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class ProcessController : Controller
    {
        public IActionResult Process()
        {
            return View();
        }
    }
}
