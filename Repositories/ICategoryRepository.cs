using Wholesaler.Models;
using System.Linq;

namespace Wholesaler.Repositories
{
    public interface ICategoryRepository
    {
         IQueryable<Category> Categories {get; }
         void SaveCategory(Category category);
         Category DeleteCategory(int categoryId);
    }
}