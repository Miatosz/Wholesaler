using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wholesaler.Models
{
    public class Product
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}

        [ForeignKey("Category")]
        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }
}