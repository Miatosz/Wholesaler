using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Wholesaler.Models.ViewModels
{
    public class OrderViewModel
    {
        public Order order {get; set;}
        public IEnumerable<Shop> Shops {get; set;}
        public IEnumerable<Wholesaler> Wholesalers {get; set;}
        public IEnumerable<Product> Products {get; set;}
        

        [Display(Name = "Shop")]
        public int SelectedShopId { get; set; }
        public IDictionary<int, string> AvailableShops {get; set;}

    }
}