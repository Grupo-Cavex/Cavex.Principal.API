namespace Cavex.Principal.Core.Specifications.EmpCatMunicipio
{
    public class EmpCatMunicipioCountSpecification : BaseSpecification<Entities.EmpCatMunicipio>
    {
        public EmpCatMunicipioCountSpecification(string? search)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
        }
    }
}