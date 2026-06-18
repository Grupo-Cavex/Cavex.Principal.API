using AutoMapper;
using Cavex.Principal.API.Dtos.EmpCatNacionalidad;
using Cavex.Principal.Core.Entities;

namespace Cavex.Principal.API.Mapping
{
    public class EmpCatNacionalidadProfile : Profile
    {
        public EmpCatNacionalidadProfile()
        {
            CreateMap<EmpCatNacionalidad, EmpCatNacionalidadDto>();
            CreateMap<EmpCatNacionalidadCreateDto, EmpCatNacionalidad>();
            CreateMap<EmpCatNacionalidadUpdateDto, EmpCatNacionalidad>();
        }
    }
}