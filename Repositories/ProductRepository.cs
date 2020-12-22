using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;
        public ProductRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;

        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
            {
                context.Products.Add(product);
            }
            else 
            {
                Product dbAdd = context.Products
                    .FirstOrDefault(p => p.Id == product.Id);
                if ( dbAdd != null)
                {
                    dbAdd.Name = product.Name;
                    dbAdd.Description = product.Description;
                    dbAdd.Price = product.Price;
                    dbAdd.Category = product.Category;
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int productID)
        {
            Product dbDel = context.Products
                .FirstOrDefault(p => p.Id == productID);
            if (dbDel != null)
            {
                context.Products.Remove(dbDel);
                context.SaveChanges();
            }
            return dbDel;
        }
    }
}