using API.Errors;
using Core.Entities.Basket_Entities;
using Core.Interfaces.Services;
using DotNetCore_ECommerce.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class PaymentController : BaseController
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [ProducesResponseType(typeof(Basket), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
        [HttpPost("{basketId}")]
        [Authorize]
        public async Task<ActionResult<Basket>> CreateOrUpdatePaymentIntend(string basketId)
        {
            var basket = await _paymentService.CreateOrUpdatePaymentIntent(basketId);

            if (basket is null)
                return BadRequest(new ApiResponse(400));

            return Ok(basket);
        }
    }
}