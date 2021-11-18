using Microsoft.AspNetCore.Mvc;
using FederatedExampleService.Models;

namespace FederatedExampleService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<CartResponse> AddToCartAsync([FromQuery] CartRequest request)
        {
            if (request != null && request.Sku != null)
                return CartResponse.FromDto();

            return new CartResponse();
        }
    }
}
