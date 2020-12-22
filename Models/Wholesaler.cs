using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wholesaler.Models
{
    public class Wholesaler
    {
        [Key]
        public int WholesalerId {get; set;}
        public string Name {get; set;}
        public string Street {get; set;}
        public string City {get; set;}
        public string PostalCode {get; set;}
        public string Email {get; set;}
        

        [ForeignKey("Category")]
        public int WarehouseId {get; set;}
        public Warehouse Warehouse {get; set;}
    }
}