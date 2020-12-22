using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Wholesaler.Models
{
    public class Category
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}

        public ICollection<Product> Products {get; set;}
    }
}