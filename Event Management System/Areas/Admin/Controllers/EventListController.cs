using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventListController : Controller
    {
        public IActionResult EventList()
        {
            return View();
        }
    }
}
