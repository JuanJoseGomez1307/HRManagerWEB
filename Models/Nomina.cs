using System.ComponentModel.DataAnnotations;

namespace HRManagerWEB.Models
{
    public class Nomina
    {
        [Key]
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public Empleado? Empleado { get; set; } = default!;
        public DateTime PeriedoInicio { get; set; }
        public DateTime PeriedoFin { get; set; }
        public decimal TotalPagado { get; set; }
    }
}
