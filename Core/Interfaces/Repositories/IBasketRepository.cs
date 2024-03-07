using Core.Entities.Basket_Entities;

namespace Core.Interfaces.Repositories
{
    public interface IBasketRepository
    {
        Task<Basket?> CreateOrUpdateBasketAsync(Basket basket);
        Task<Basket?> GetBasketAsync(string basketId);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}