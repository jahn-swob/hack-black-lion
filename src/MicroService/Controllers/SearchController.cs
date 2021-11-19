using MicroService.Core.Application.Services;
using MicroService.Models.Search;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;
        private readonly ISearchService _search;

        public SearchController(ILogger<SearchController> logger, ISearchService search)
        {
            _logger = logger;
            _search = search;
        }

        [HttpGet]
        public async Task<SearchResponse> GetSearchResultAsync([FromQuery] SearchRequest request)
        {
            var result = await _search.GetSearchAsync(request.ToDto());
            var response = SearchResponse.FromDto(result);
            return response;
        }
    }
}
