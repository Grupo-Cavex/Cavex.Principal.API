using AutoMapper;
using Cavex.Principal.API.Dtos.EmpCatEstadoCivil;
using Cavex.Principal.Core.Entities;

namespace Cavex.Principal.API.Mapping
{
    public class EmpCatEstadoCivilProfile : Profile
    {
        public EmpCatEstadoCivilProfile()
        {
            CreateMap<EmpCatEstadoCivil, EmpCatEstadoCivilDto>();
            CreateMap<EmpCatEstadoCivilCreateDto, EmpCatEstadoCivil>();
            CreateMap<EmpCatEstadoCivilUpdateDto, EmpCatEstadoCivil>();
        }
    }
}