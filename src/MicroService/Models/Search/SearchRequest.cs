using System.ComponentModel.DataAnnotations;
using MicroService.Core.DataTransferObjects.Search;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Models.Search
{
    public class SearchRequest
    {
        [FromQuery(Name = "q")]
        [Required(ErrorMessage = "Parameter 'query' is required.")]
        public string Query { get; set; } = string.Empty;

        public SearchRequestDto ToDto() => new SearchRequestDto
        {
            Query = Query
        };
    }
}
