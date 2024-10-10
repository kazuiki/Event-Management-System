using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class RecieptController : Controller
    {
        public IActionResult Reciept()
        {
            return View();
        }
    }
}
