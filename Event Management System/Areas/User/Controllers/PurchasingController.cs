using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Areas.User.Controllers
{
    [Area("User")]
    public class PurchasingController : Controller
    {
        public IActionResult Purchasing()
        {
            return View();
        }
    }
}
