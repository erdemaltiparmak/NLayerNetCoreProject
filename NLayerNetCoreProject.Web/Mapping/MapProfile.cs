using AutoMapper;
using NLayerNetCoreProject.API.DataTransferObjects;
using NLayerNetCoreProject.Core.DataTransferObjects;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerNetCoreProject.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();
            CreateMap<CategoryWithProductsDto, Category>();
            CreateMap<CategoryDto, Category>();
            CreateMap<ProductDto, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();

        }
    }

}
