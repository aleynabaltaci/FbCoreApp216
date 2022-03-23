using AutoMapper;
using FbCoreApp216.Api.DTOs;
using FbCoreApp216.Core.Models;

namespace FbCoreApp216.Api.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Category, CategoryWtihProductDto>();
            CreateMap<CategoryWtihProductDto, Category>();


            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();


        }
    }
}
