using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public interface IShopRepository
    {
        IQueryable<Shop> Shops {get;}
        void SaveShop(Shop shop);
        Shop DeleteShop(int shopId);
    }
}