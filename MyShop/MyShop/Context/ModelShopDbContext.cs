using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.Context
{
    public class ModelShopDbContext:DbContext
    {
        public ModelShopDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
