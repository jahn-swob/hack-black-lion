namespace MicroService.Configuration
{
    public class SearchProviderOptions
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string SecretName { get; set; } = string.Empty;
        public string RouteFormat { get; set; } = string.Empty;
    }
}
