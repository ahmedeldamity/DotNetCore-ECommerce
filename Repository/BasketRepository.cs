﻿using Core.Entities.Basket_Entities;
using Core.Interfaces.Repositories;
using StackExchange.Redis;
using System.Text.Json;

namespace Repository
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;
        public BasketRepository(IConnectionMultiplexer connection)
        {
            _database = connection.GetDatabase();
        }
        public async Task<Basket?> CreateOrUpdateBasketAsync(Basket basket)
        {
            var createdOrUpdated = await _database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), TimeSpan.FromDays(30));
            if (createdOrUpdated is false) return null;
            return await GetBasketAsync(basket.Id);
        }
        public async Task<bool> DeleteBasketAsync(string basketId)
        {
            return await _database.KeyDeleteAsync(basketId);
        }
        public async Task<Basket?> GetBasketAsync(string basketId)
        {
            var basket = await _database.StringGetAsync(basketId);
            return basket.IsNullOrEmpty ? null : JsonSerializer.Deserialize<Basket>(basket);
        }
    }
}