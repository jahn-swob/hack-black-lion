namespace FederatedExampleService.Core.DataTransferObjects.Search
{
    public class SearchResponseDto
    {
        public int TotalCount { get; set; }
        public List<ProductDto> ProductResults { get; set; } = new List<ProductDto>();
    }
}
