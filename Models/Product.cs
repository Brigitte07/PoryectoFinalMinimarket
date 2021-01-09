using System.ComponentModel.DataAnnotations;

namespace Market.Models
{
    public class Product
    {
        public int Id{get;set;}
        [Required(ErrorMessage ="EL nombre no puede estar vacio")]
        public string Name{get;set;}
        [Required(ErrorMessage ="El costo no puede estar vacio")]
        public double Cost{get;set;}
        public int CategoryId{get;set;}
        public Category Category{get;set;}
    }
}