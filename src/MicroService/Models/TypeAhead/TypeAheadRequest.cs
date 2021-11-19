using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FederatedExampleService.Models.TypeAhead
{
    public class TypeAheadRequest
    {
        [Required(ErrorMessage = "Locale is required")]
        [FromQuery(Name = "locale")]        
        public string Locale { get; set; } = string.Empty;

        [FromQuery(Name = "q")]
        [Required(ErrorMessage = "Query is required")]
        public string Query { get; set; } = string.Empty;

        [FromQuery(Name = "limit")]
        public int Limit { get; set; }

        [FromQuery(Name = "offset")]
        public int Offset { get; set; }

        [FromQuery(Name = "type")]        
        public string Type { get; set; } = string.Empty;
    }
}
