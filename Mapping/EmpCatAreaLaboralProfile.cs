using AutoMapper;

namespace Cavex.Principal.API.Mapping
{
    public class EmpCatAreaLaboralProfile:Profile
    {
        public EmpCatAreaLaboralProfile()
        {
            CreateMap<Cavex.Principal.Core.Entities.EmpCatAreaLaboral, Dtos.EmpCatAreaLaboral.EmpCatAreaLaboralDto>();
            CreateMap<Dtos.EmpCatAreaLaboral.EmpCatAreaLaboralCreateDto, Cavex.Principal.Core.Entities.EmpCatAreaLaboral>();
            CreateMap<Dtos.EmpCatAreaLaboral.EmpCatAreaLaboralUpdateDto, Cavex.Principal.Core.Entities.EmpCatAreaLaboral>();
        }
    }
}
