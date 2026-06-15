namespace Cavex.Principal.Core.Specifications.EmpCatGenero
{
    public class EmpCatGeneroSpecification : BaseSpecification<Entities.EmpCatGenero>
    {
        public EmpCatGeneroSpecification(string? search, int pageIndex, int pageSize)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
            AddOrderBy(x => x.StrValor);

            var skip = (pageIndex - 1) * pageSize;

            ApplyPaging(skip, pageSize);
        }

        public EmpCatGeneroSpecification(int id)
            : base(x => x.Id == id)
        {
        }
    }
}