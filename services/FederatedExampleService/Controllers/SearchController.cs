using Microsoft.AspNetCore.Mvc;
using FederatedExampleService.Models;

namespace FederatedExampleService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<SearchResponse> GetSearchResultAsync([FromQuery] SearchRequest request)
        {
            if (request != null && request.Query != null)
                return SearchResponse.FromDto();

            return new SearchResponse();
        }
    }
}
