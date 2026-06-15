namespace Cavex.Principal.Core.Specifications.EmpCatNacionalidad
{
    public class EmpCatNacionalidadSpecification : BaseSpecification<Entities.EmpCatNacionalidad>
    {
        public EmpCatNacionalidadSpecification(string? search, int pageIndex, int pageSize)
            : base(x => string.IsNullOrWhiteSpace(search) || x.StrValor.Contains(search))
        {
            AddOrderBy(x => x.StrValor);

            var skip = (pageIndex - 1) * pageSize;

            ApplyPaging(skip, pageSize);
        }

        public EmpCatNacionalidadSpecification(int id)
            : base(x => x.Id == id)
        {
        }
    }
}