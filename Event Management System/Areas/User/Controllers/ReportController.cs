using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class ReportController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }
    }
}
