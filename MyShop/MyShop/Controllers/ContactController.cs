using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
