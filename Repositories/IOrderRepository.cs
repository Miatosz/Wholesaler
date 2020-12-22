using System.Linq;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}