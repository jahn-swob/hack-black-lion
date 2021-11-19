namespace FederatedExampleService.Core.Domain.Queries
{
    public class TypeAheadQuery
    {
        public string Locale { get; set; } = string.Empty;
        public string Query { get; set; } = string.Empty;
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
