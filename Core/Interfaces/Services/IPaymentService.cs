using Core.Entities.Basket_Entities;

namespace Core.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<Basket?> CreateOrUpdatePaymentIntent(string basketId);
    }
}