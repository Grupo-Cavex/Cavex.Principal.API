namespace Cavex.Principal.Core.Specifications.EmpCatGenero
{
    public class EmpCatGeneroCountSpecification : BaseSpecification<Entities.EmpCatGenero>
    {
        public EmpCatGeneroCountSpecification(string? search)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
        }
    }
}