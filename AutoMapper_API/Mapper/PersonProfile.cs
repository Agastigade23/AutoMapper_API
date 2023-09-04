using AutoMapper;
using AutoMapper_API.Entities;
using AutoMapper_API.Resources;

namespace AutoMapper_API.Mapper
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonResource>()
                .ForMember(x => x.Id, o => o.MapFrom(x => x.Id))
                .ForMember(x => x.FirstName,o=> o.MapFrom(x=>x.FirstName))
                .ForMember(x => x.FirstName, o => o.MapFrom(x => x.FirstName))
                .ForMember(t => t.LastName, o => o.MapFrom(t => t.LastName))
                .ForMember(t => t.CreatedAt, o => o.MapFrom(t => t.CreatedAt))
                .ForMember(t => t.UpdatedAt, o => o.MapFrom(t => t.UpdatedAt))
                .ForMember(t => t.Addresses, o => o.MapFrom(t => t.Addresses))
                .ReverseMap();

        }
    }
}
