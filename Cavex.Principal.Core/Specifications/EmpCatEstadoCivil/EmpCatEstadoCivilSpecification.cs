namespace Cavex.Principal.Core.Specifications.EmpCatEstadoCivil
{
    public class EmpCatEstadoCivilSpecification : BaseSpecification<Entities.EmpCatEstadoCivil>
    {
        public EmpCatEstadoCivilSpecification(string? search, int pageIndex, int pageSize)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
            AddOrderBy(x => x.StrValor);

            var skip = (pageIndex - 1) * pageSize;

            ApplyPaging(skip, pageSize);
        }

        public EmpCatEstadoCivilSpecification(int id)
            : base(x => x.Id == id)
        {
        }
    }
}