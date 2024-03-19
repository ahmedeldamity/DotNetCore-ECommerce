using API.Dtos;
using AutoMapper;
using Core.Entities.Order_Entities;

namespace DotNetCore_ECommerce.Helpers
{
    public class ProductImageCoverInOrderResolver : IValueResolver<OrderItem, OrderItemDto, string>
    {
        private readonly IConfiguration _configuration;

        public ProductImageCoverInOrderResolver(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.Product.ProductImageCover))
            {
                return $"{_configuration["ApiBaseUrl"]}/{source.Product.ProductImageCover}";
            }
            return string.Empty;
        }
    }
}
