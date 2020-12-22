using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace Wholesaler.Models
{
    public class Shop
    {
        public int ShopId {get; set;}
        public string Name {get; set;}
        public string City {get; set;}
        public string Street {get; set;}
        public string PostalCode {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}    
    }
}