using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }
    }
}
