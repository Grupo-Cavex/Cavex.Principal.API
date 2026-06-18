namespace Cavex.Principal.Core.Specifications.EmpCatEstadoCivil
{
    public class EmpCatEstadoCivilCountSpecification : BaseSpecification<Entities.EmpCatEstadoCivil>
    {
        public EmpCatEstadoCivilCountSpecification(string? search)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
        }
    }
}