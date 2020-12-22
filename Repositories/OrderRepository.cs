using System.Linq;
using Microsoft.EntityFrameworkCore;
using Wholesaler.Models;

namespace Wholesaler.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        

        public OrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders;
    
    
        public void SaveOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                context.Orders.Add(order);
            }
            
            context.SaveChanges();
        }
    }
}