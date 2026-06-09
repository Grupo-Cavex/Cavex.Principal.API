using System.ComponentModel.DataAnnotations;

namespace Cavex.Principal.API.Dtos.EmpCatAreaLaboral
{
    public class EmpCatAreaLaboralUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string StrValor { get; set; } = string.Empty;

        [MaxLength(300)]
        public string? StrDescripcion { get; set; }
    }
}
