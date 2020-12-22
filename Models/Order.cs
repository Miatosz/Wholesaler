using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Collections.Generic;


namespace Wholesaler.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey("Wholesaler")]
        public int WholesalerId { get; set; }
        public Wholesaler Wholesaler { get; set; }


        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}