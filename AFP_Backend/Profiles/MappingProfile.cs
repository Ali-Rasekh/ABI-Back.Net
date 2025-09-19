using AutoMapper;
using Contract.Dtos.MaroonModels;
using MaroonModels;

namespace AFP_Backend.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BiFilter, BiFilterDto>().ReverseMap();
           
        }
    }
}
