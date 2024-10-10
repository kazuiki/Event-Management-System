using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EditEventController : Controller
    {
        public IActionResult EditEvent()
        {
            return View();
        }
    }
}
