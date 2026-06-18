using AutoMapper;
using Cavex.Principal.API.Dtos.EmpCatGenero;
using Cavex.Principal.Core.Entities;

namespace Cavex.Principal.API.Mapping
{
    public class EmpCatGeneroProfile : Profile
    {
        public EmpCatGeneroProfile()
        {
            CreateMap<EmpCatGenero, EmpCatGeneroDto>();
            CreateMap<EmpCatGeneroCreateDto, EmpCatGenero>();
            CreateMap<EmpCatGeneroUpdateDto, EmpCatGenero>();
        }
    }
}