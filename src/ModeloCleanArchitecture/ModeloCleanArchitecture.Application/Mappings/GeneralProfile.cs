using AutoMapper;
using ModeloCleanArchitecture.Application.Features.Products.Commands.CreateProduct;
using ModeloCleanArchitecture.Application.Features.Products.Queries.GetAllProducts;
using ModeloCleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloCleanArchitecture.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
