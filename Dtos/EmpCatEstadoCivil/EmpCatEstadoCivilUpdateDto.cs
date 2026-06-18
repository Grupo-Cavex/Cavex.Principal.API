using System.ComponentModel.DataAnnotations;

namespace Cavex.Principal.API.Dtos.EmpCatEstadoCivil
{
    public class EmpCatEstadoCivilUpdateDto
    {
        [Required]
        [MaxLength(150)]
        public string StrValor { get; set; } = string.Empty;

        [MaxLength(450)]
        public string? StrDescripcion { get; set; }
    }
}