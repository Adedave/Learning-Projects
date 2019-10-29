using AutoMapper;
using SuperMarket.Api.Domain.Models;
using SuperMarket.Api.Resources;

namespace SuperMarket.Api.Mapping
{
    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
