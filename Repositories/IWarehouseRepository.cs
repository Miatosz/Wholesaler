using Wholesaler.Models;
using System.Linq;

namespace Wholesaler.Repositories
{
    public interface IWarehouseRepository
    {
         IQueryable<Warehouse> Warehouses { get; }

         void DecreaseAvailableProducts(int warehouseId, int productId, int quantity);

    }
}