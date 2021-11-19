using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Models.Cart
{
    public class CartRequest
    {
        [FromQuery(Name = "sku")]
        [Required(ErrorMessage = "Parameter 'sku' is required.")]
        public string Sku { get; set; } = string.Empty;
    }
}
