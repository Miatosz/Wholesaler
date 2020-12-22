using System.Linq;
namespace Wholesaler.Models
{
    public interface IWholesalerRepository
    {
          IQueryable<Wholesaler> Wholesalers {get;}

          void SaveWholesaler(Wholesaler wholesaler);

          Wholesaler DeleteWholesaler(int wholesalerId);
    }
}