using Wholesaler.Models;
using System.Linq;

namespace Wholesaler.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {

        private ApplicationDbContext context;

        public WarehouseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Warehouse> Warehouses => context.Warehouses;

        public void DecreaseAvailableProducts(int warehouseId, int productId, int quantity)
        {
            var warehouse = context.Warehouses.FirstOrDefault(w => w.Id == warehouseId);
            warehouse.ProductsQuntity -= quantity;

            context.SaveChanges();
        }


    }
}