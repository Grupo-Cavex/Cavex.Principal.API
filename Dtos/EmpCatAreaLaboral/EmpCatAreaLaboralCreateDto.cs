using System.ComponentModel.DataAnnotations;

namespace Cavex.Principal.API.Dtos.EmpCatAreaLaboral
{
    public class EmpCatAreaLaboralCreateDto
    {
        [Required]
        [MaxLength(150)]
        public string StrValor { get; set; } = string.Empty;

        [MaxLength(300)]
        public string? StrDescripcion { get; set; }
    }

}
