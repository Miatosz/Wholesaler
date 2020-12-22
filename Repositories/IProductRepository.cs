using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public interface IProductRepository
    {
         IQueryable<Product> Products {get;}
         void SaveProduct(Product product);
         Product DeleteProduct(int productID);

    }
}