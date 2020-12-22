using Wholesaler.Models;
using System.Linq;

namespace Wholesaler.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext context;
        public CategoryRepository (ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Category> Categories => context.Categories;

        public void SaveCategory(Category category)
        {
            if (category.Id == 0)
            {
                context.Categories.Add(category);
            }
            else 
            {
                Product dbAdd = context.Products
                    .FirstOrDefault(p => p.Id == category.Id);
                if ( dbAdd != null)
                {
                    dbAdd.Name = category.Name;
                }
            }
            context.SaveChanges();
        }

        public Category DeleteCategory(int categoryId)
        {
            Category dbDel = context.Categories
                .FirstOrDefault(c => c.Id == categoryId);
            if (dbDel != null)
            {
                context.Categories.Remove(dbDel);
                context.SaveChanges();
            }
            return dbDel;
        }

    }
}
