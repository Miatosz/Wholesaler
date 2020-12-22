using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Wholesaler.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options) {}    


        public DbSet<Product> Products {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Shop> Shops {get; set;}
        public DbSet<Wholesaler> Wholesalers {get; set;}
        public DbSet<Warehouse> Warehouses {get; set;}

    }
}