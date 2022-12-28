using Microsoft.AspNetCore.Mvc;
using MyShop.Context;
using MyShop.Models;

namespace MyShop.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly ModelShopDbContext _context;
        public CategoryController(ModelShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> list = _context.categories.ToList();
            return View(list);
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
