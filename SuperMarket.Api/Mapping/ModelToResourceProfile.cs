using SuperMarket.Api.Domain.Models;
using SuperMarket.Api.Resources;
using AutoMapper;
using SuperMarket.Api.Extensions;

namespace SuperMarket.Api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
