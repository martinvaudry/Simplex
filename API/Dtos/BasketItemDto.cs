using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class BasketItemDto
    {   
        [Required]
        public int Id {get; set;}
        [Required]
        public string ProductName {get; set;}
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = " Le prix doit être plus grand que 0$")] // prix minimum
        public decimal Price {get; set;}
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = " La quantité minimal est de 1 item")] //quantité minimum
        public int Quantity {get; set;}
        [Required]
        public string PictureUrl {get; set;}
        [Required]
        public string Brand {get; set;}
        [Required]
        public string Type {get; set;}
    }
}