using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FederatedExampleService.Core.DataTransferObjects.Search;

namespace FederatedExampleService.Models.Search
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
