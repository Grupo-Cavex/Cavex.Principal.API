using AutoMapper;
using Cavex.Principal.API.Dtos.EmpCatMunicipio;
using Cavex.Principal.Core.Entities;

namespace Cavex.Principal.API.Mapping
{
    public class EmpCatMunicipioProfile : Profile
    {
        public EmpCatMunicipioProfile()
        {
            CreateMap<EmpCatMunicipio, EmpCatMunicipioDto>();
            CreateMap<EmpCatMunicipioCreateDto, EmpCatMunicipio>();
            CreateMap<EmpCatMunicipioUpdateDto, EmpCatMunicipio>();
        }
    }
}