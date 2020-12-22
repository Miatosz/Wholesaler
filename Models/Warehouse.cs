using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wholesaler.Models
{
    public class Warehouse
    {
        [Key]
        public int Id {get; set;}        
        public int ProductsQuntity {get; set;}
        public bool IsAvailable {get; set;}       
        public Product Product {get; set;}
        

        public ICollection<Wholesaler> Wholesalers {get; set;}

    }
}