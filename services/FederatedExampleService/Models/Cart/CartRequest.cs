using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FederatedExampleService.Models
{
    public class CartRequest
    {
        [FromQuery(Name = "sku")]
        [Required(ErrorMessage = "Parameter 'sku' is required.")]
        public string Sku { get; set; } = string.Empty;
    }
}
