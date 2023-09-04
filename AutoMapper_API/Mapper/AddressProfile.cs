using AutoMapper;
using AutoMapper_API.Entities;
using AutoMapper_API.Resources;

namespace AutoMapper_API.Mapper
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressResource>()
                .ForMember(t => t.Id, o => o.MapFrom(t => t.Id))
                .ForMember(t => t.Country, o => o.MapFrom(t => t.Country))
                .ForMember(t => t.POBox, o => o.MapFrom(t => t.POBox))
                .ForMember(t => t.City, o => o.MapFrom(t => t.City))
                .ForMember(t => t.Street, o => o.MapFrom(t => t.Street))
                .ForMember(t => t.Apartment, o => o.MapFrom(t => t.Apartment))
                .ForMember(t => t.CreatedAt, o => o.MapFrom(t => t.CreatedAt))
                .ForMember(t => t.UpdatedAt, o => o.MapFrom(t => t.UpdatedAt))
                .ForMember(t => t.Person, o => o.MapFrom(t => t.Person))
                .ReverseMap();
        }
    }
}
