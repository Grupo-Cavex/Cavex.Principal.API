namespace Cavex.Principal.Core.Specifications.EmpCatNacionalidad
{
    public class EmpCatNacionalidadCountSpecification : BaseSpecification<Entities.EmpCatNacionalidad>
    {
        public EmpCatNacionalidadCountSpecification(string? search)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
        }
    }
}