﻿using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Repository;
using Service;

namespace DotNetCore_ECommerce.ServicesExtension
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // --- Bad Way To Register Dependancy Injection Of Generic Repositories
            //builder.Services.AddScoped<IGenericRepositories<Product>, GenericRepositories<Product>>();
            //builder.Services.AddScoped<IGenericRepositories<ProductBrand>, GenericRepositories<ProductBrand>>();
            //builder.Services.AddScoped<IGenericRepositories<ProductCategory>, GenericRepositories<ProductCategory>>();
            // --- Right Way To Register Dependancy Injection Of Generic Repositories
            //services.AddScoped(typeof(IGenericRepositories<>), typeof(GenericRepositories<>));
            // --- but I commented this line because i used unit-of-work then
            // --- I at all time create instance in unit-of-work then instead of dependency injection

            // Register Unit Of Work
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            // Register Product Service
            services.AddScoped(typeof(IProductService), typeof(ProductService));

            return services;
        }
    }
}
