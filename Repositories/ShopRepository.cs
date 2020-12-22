using System;
using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ApplicationDbContext context;

        public ShopRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IQueryable<Shop> Shops => context.Shops;

        public void SaveShop(Shop shop)
        {
            if (shop.ShopId == 0)
            {
                context.Shops.Add(shop);
            } else 
            {
                Shop dbEntry = context.Shops.FirstOrDefault(s => s.ShopId == shop.ShopId);
                if (dbEntry != null)
                {
                    dbEntry.Name = shop.Name;
                    dbEntry.Street = shop.Street;
                    dbEntry.PostalCode = shop.Street;
                    dbEntry.PhoneNumber = shop.PhoneNumber;
                    //dbEntry.WarehouseId = shop.WarehouseId;
                    dbEntry.City = shop.City;
                    dbEntry.Email = shop.Email;

                }
            }
            context.SaveChanges();
        }

        public Shop DeleteShop(int shopId)
        {
            Shop dbdel = context.Shops
                            .FirstOrDefault(s => s.ShopId == shopId);
            if (dbdel != null)
            {
                context.Remove(dbdel);
                context.SaveChanges();
            }

            return dbdel;
        }
        
    }
}