using System.ComponentModel.DataAnnotations;

namespace HRManagerWEB.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string? Ubicacion { get; set; }
    }
}
