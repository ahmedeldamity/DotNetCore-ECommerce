using Core.Entities.Basket_Entities;
using Core.Entities.Order_Entities;

namespace Core.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<Basket?> CreateOrUpdatePaymentIntent(string basketId);

        Task<Order> UpdatePaymentIntentToSucceededOrFailed(string paymentIntentId, bool isSucceeded);
    }
}