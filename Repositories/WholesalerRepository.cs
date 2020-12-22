using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public class WholesalerRepository : IWholesalerRepository
    {
        private readonly ApplicationDbContext context;

        public WholesalerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Models.Wholesaler> Wholesalers => context.Wholesalers;

        public void SaveWholesaler(Models.Wholesaler wholesaler)
        {
            if (wholesaler.WholesalerId == 0)
            {
                context.Wholesalers.Add(wholesaler); 
            } else
            {
                Models.Wholesaler dbEntry = context.Wholesalers
                                        .FirstOrDefault(w => w.WholesalerId == wholesaler.WholesalerId);
                
                if (dbEntry != null)
                {
                    dbEntry.Name = wholesaler.Name;
                    dbEntry.Street = wholesaler.Street;
                    dbEntry.City = wholesaler.City;
                    dbEntry.PostalCode = wholesaler.PostalCode;
                    dbEntry.Email = wholesaler.Email;
                }
            }

            context.SaveChanges();

        }

        public Models.Wholesaler DeleteWholesaler(int wholesalerId)
        {
            Models.Wholesaler dbDel = context.Wholesalers
                .FirstOrDefault(w => w.WholesalerId == wholesalerId);
            if (dbDel != null)
            {
                context.Wholesalers.Remove(dbDel);
                context.SaveChanges();
            }
            return dbDel;
        }
    }
}