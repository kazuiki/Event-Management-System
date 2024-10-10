using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
