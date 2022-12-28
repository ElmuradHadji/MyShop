using Microsoft.AspNetCore.Mvc;
using MyShop.Context;
using MyShop.Models;
using System.Diagnostics;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelShopDbContext _context;
        public HomeController(ModelShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> list = _context.categories.ToList();
            return View(list);

        }

       
    }
}