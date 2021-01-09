using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Models
{
    public class Trash
    {
        public int Id{get;set;}
        [Required(ErrorMessage ="EL nombre no puede estar vacio")]
        public string ProductsName{get;set;}
        [Required(ErrorMessage ="El costo no puede estar vacio")]
        public double ProductsCost{get;set;}
        public string Adress{get;set;}
        public string DeliveryTime{get;set;}
        public string PhoneNumber{get;set;}
    }
}