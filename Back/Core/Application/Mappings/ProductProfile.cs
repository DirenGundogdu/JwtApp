using AutoMapper;
using Back.Core.Application.Dto;
using Back.Core.Domain;

namespace Back.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}
