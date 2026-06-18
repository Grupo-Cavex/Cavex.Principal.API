namespace Cavex.Principal.API.Dtos.EmpCatMunicipio
{
    public class EmpCatMunicipioDto
    {
        public int Id { get; set; }

        public string StrValor { get; set; } = string.Empty;

        public string? StrDescripcion { get; set; }

        public int IdEmpCatEntidadFederativa { get; set; }
    }
}