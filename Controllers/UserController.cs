using System.Diagnostics;
using Wholesaler.Models;
using Wholesaler.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Wholesaler.Repositories;


namespace Wholesaler.Controllers
{
    public class UserController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IShopRepository shopRepository;
        private readonly IWholesalerRepository wholesalerRepository;
        private readonly IWarehouseRepository warehouseRepository;
        private IOrderRepository repository;
        private ApplicationDbContext context;

    
        public UserController(ApplicationDbContext context, IProductRepository productRepository, IShopRepository shopRepository, 
                                IWholesalerRepository wholesalerRepository,
                                IOrderRepository repository,
                                IWarehouseRepository warehouseRepository)
        {
            this.context = context;
            this.repository = repository;
            this.productRepository = productRepository;
            this.shopRepository = shopRepository;
            this.wholesalerRepository = wholesalerRepository;
            this.warehouseRepository = warehouseRepository;
        }

       
        public ViewResult List()
            => View(new ProductListViewModel
            {
                Products = productRepository.Products,           
            });

    
         public ViewResult Checkout(int productId) 
            {               
                IEnumerable<SelectListItem> shops = context.Shops.Select(c => new SelectListItem
                {
                      Value = c.ShopId.ToString(),
                      Text = c.Name
 
                });
                
                ViewBag.Shops = shops;    
                return View(new Order
                {
                    ProductId = productId,
                    Product = productRepository.Products.FirstOrDefault(p => p.Id == productId)                 
                });
                
            } 

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var wholesaler = context.Wholesalers.FirstOrDefault(p => p.Warehouse.Product.Id == order.ProductId);
            order.WholesalerId = wholesaler.WholesalerId;
            var product = productRepository.Products.FirstOrDefault(p => p.Id == order.ProductId);
            order.TotalPrice = order.Quantity * product.Price;
            warehouseRepository.DecreaseAvailableProducts(wholesaler.WholesalerId, product.Id, order.Quantity);
            repository.SaveOrder(order);
            return RedirectToAction("List");     
        }

    }
}