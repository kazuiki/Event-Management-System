using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
    }
}
