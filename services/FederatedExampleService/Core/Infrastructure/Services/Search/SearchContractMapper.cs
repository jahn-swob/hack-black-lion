using System.Globalization;
using System.Text.RegularExpressions;
using System.Web;
using FederatedExampleService.Configuration;
using FederatedExampleService.Core.Infrastructure.Contracts.Search;
using FederatedExampleService.Interfaces;

namespace FederatedExampleService.Core.Infrastructure.Services.Search
{
    public class SearchContractMapper : ISearchContractMapper
    {
        private static readonly Regex HyphenatedSkuCapture = new Regex(@"^([0-9]+)-([0-9]+)$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        private readonly ILogger<SearchContractMapper> _log;

        public SearchContractMapper(ILogger<SearchContractMapper> log)
        {
            _log = log;
        }

        public string BuildRoute(SearchQueryRequestContract query)
        {
            var application = "crateandbarrel";
            var profile = "crateandbarrel_com";
            var routeFormat = "query/{1}_{2}?{3}";
            var result = HttpUtility.ParseQueryString(string.Empty);

            result["q"] = HyphenatedSkuCapture.Replace(query.Query, "$1$2");

            result["rows"] = "100";
            result["start"] = "0";
            

            return string.Format(routeFormat, application, profile, "search", result);
        }

        public SearchQueryResponseContract BuildResponse(SearchResponse response, SearchQueryRequestContract query)
        {
            return new SearchQueryResponseContract
            {
                TotalCount = response.Response.NumFound,
                ProductResults = response.Response.Documents.Select(p => p.Convert<ProductContract>()).ToList()
            };
        }
    }
}
