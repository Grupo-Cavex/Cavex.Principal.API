namespace Cavex.Principal.Core.Specifications.EmpCatMunicipio
{
    public class EmpCatMunicipioSpecification : BaseSpecification<Entities.EmpCatMunicipio>
    {
        public EmpCatMunicipioSpecification(string? search, int pageIndex, int pageSize)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
            AddOrderBy(x => x.StrValor);

            var skip = (pageIndex - 1) * pageSize;

            ApplyPaging(skip, pageSize);
        }

        public EmpCatMunicipioSpecification(int id)
            : base(x => x.Id == id)
        {
        }
    }
}