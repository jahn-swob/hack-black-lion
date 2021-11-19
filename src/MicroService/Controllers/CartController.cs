using MicroService.Models.Cart;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.Controllers
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
        public Task<CartResponse> AddToCartAsync([FromQuery] CartRequest? request)
        {
            if (request?.Sku != null)
                return Task.FromResult(CartResponse.FromDto());

            return Task.FromResult(new CartResponse());
        }
    }
}
