using System.Text.Json.Serialization;

namespace FederatedExampleService.Models
{
    public class CartResponse
    {
        [JsonPropertyName("is_success")]
        public bool IsSuccess { get; set; }

        public static CartResponse FromDto()
        {
            return new CartResponse
            {
                IsSuccess = true
            };
        }
    }
}
