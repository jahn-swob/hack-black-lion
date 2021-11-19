using System.Text;
using System.Text.Json;
using MicroService.Core.Infrastructure.Contracts.Search;

namespace MicroService.Core.Infrastructure.Services.Search
{
    public class SearchProvider : ISearchProvider
    {
        private readonly ILogger<SearchProvider> _log;
        private readonly HttpClient _client;
        private readonly ISearchContractMapper _contractMapper;

        public SearchProvider(ILogger<SearchProvider> log, HttpClient client, ISearchContractMapper contractMapper)
        {
            _log = log;
            _client = client;
            _contractMapper = contractMapper;
        }

        public async Task<SearchQueryResponseContract> GetSearchQueryResponseAsync(SearchQueryRequestContract query)
        {
            var route = _contractMapper.BuildRoute(query);
            using var request = new HttpRequestMessage(HttpMethod.Get, route);
            _client.BaseAddress = new Uri($"https://crateandbarrel-stg.b.lucidworks.cloud/api/");

            var byteArray = Encoding.ASCII.GetBytes("search_svc:MWUzY2RmNWNjMzg4");
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            using var response = await _client.SendAsync(request);
            await response.Content.LoadIntoBufferAsync();

            await using var stream = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<SearchResponse>(stream) ?? new SearchResponse();
            return _contractMapper.BuildResponse(result, query);
        }
    }
}
