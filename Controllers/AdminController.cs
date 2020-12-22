using System.Linq;
using System;
using System.Text.RegularExpressions;
using Wholesaler.Models;
using Wholesaler.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Http;
using Wholesaler.Repositories;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;




namespace Wholesaler.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IShopRepository shopRepository;
        private readonly IWholesalerRepository wholesalerRepository;
        private IOrderRepository repository;
        private ICategoryRepository categoryRepository;
        private readonly ApplicationDbContext context;


        public AdminController(ICategoryRepository categoryRepository, IOrderRepository repository,
            IProductRepository productRepository, IShopRepository shopRepository, 
            IWholesalerRepository wholesalerRepository, ApplicationDbContext ctx)
        {
            this.repository = repository;
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
            this.shopRepository = shopRepository;
            this.wholesalerRepository = wholesalerRepository;
            context = ctx;
        }

        
        //shops

        public IActionResult List() 
        {
            var products = context.Products.Include(c => c.Category);
            return View(products);
        }

        public ViewResult ListShops() 
            => View(shopRepository.Shops);

        public ViewResult EditShop(int shopId) 
            => View(shopRepository.Shops
                    .FirstOrDefault(s => s.ShopId == shopId));

        [HttpPost]
        public IActionResult EditShop(Shop shop)
        {
            shopRepository.SaveShop(shop);
            return RedirectToAction("ListShops");
        }

        [HttpPost]
        public IActionResult DeleteShop(int shopId)
        {
            Shop deletedShop = shopRepository.DeleteShop(shopId);
            return RedirectToAction("ListShops");
        }


        //Wholesalers
            
        public ViewResult ListWholesalers()
        {
            var wholesalers = context.Wholesalers.Include(c => c.Warehouse);
            return View(wholesalers);
        }

        public ViewResult EditWholesaler(int wholesalerId) 
            => View(wholesalerRepository.Wholesalers
                .FirstOrDefault(w => w.WholesalerId == wholesalerId));

        [HttpPost]
        public IActionResult EditWholesaler(Models.Wholesaler wholesaler)
        {            
            wholesalerRepository.SaveWholesaler(wholesaler);
            return RedirectToAction("ListWholesalers");
        }

        public IActionResult DeleteWholesaler(int wholesalerId) 
        {
            Models.Wholesaler deletedWholesaler = wholesalerRepository.DeleteWholesaler(wholesalerId);
            return RedirectToAction("ListWholesalers");
        }


        //Products

        public ViewResult EditProduct(int productId) 
        {
            IEnumerable<SelectListItem> categories = categoryRepository.Categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            });
            ViewBag.Categories = categories;
            return View(productRepository.Products.FirstOrDefault(p => p.Id == productId));
        }
                    

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            productRepository.SaveProduct(product);
            return RedirectToAction("List");            
        }
                    

        [HttpPost]
        public IActionResult DeleteProduct(int productId) 
        {
            Product deletedProduct = productRepository.DeleteProduct(productId);
            return RedirectToAction("List");
        }


        //Categories

        public IActionResult ListCategories()
            => View(categoryRepository.Categories);

        public ViewResult EditOrAddCategory(int categoryId) =>
                    View(categoryRepository.Categories
                         .FirstOrDefault(c => c.Id == categoryId));
                    

        [HttpPost]
        public IActionResult EditOrAddCategory(Category category)
        {
            categoryRepository.SaveCategory(category);
            return RedirectToAction("ListCategories");
            
        }
                    

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId) 
        {
            Category deletedCategory = categoryRepository.DeleteCategory(categoryId);
            return RedirectToAction("ListCategories");
        }

        //Orders

        public ViewResult ListOrders() 
            => View(repository.Orders.Include(p => p.Product).Include(s => s.Shop));
    }
}