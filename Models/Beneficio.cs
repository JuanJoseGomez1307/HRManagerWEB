using System.ComponentModel.DataAnnotations;

namespace HRManagerWEB.Models
{
    public class Beneficio
    {
        [Key]
        public int IdBeneficio { get; set; }
        public string? Descripcion { get; set; }
        public decimal CostoEmpresa { get; set; }
        public decimal CostoEmpleado { get; set; }
    }
}
