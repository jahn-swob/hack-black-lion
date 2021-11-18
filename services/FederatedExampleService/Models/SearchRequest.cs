using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FederatedExampleService.Models
{
    public class SearchRequest
    {
        [FromQuery(Name = "q")]
        [Required(ErrorMessage = "Parameter 'query' is required.")]
        public string Query { get; set; } = string.Empty;
    }
}
