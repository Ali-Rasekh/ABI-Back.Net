using AFP_Backend.Modules.BiFilters.Contracts.Dtos;
using AFP_Backend.Modules.BiFilters.Models;
using AutoMapper;

namespace AFP_Backend.Modules.BiFilters.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BiFilter, BiFilterDto>().ReverseMap();
        }
    }
}
