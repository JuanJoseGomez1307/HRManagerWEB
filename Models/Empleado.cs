using System.ComponentModel.DataAnnotations;

namespace HRManagerWEB.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int IdDepartamento { get; set; }
        public Departamento? Departamento { get; set; } = default!;
        public decimal Salario { get; set; }
        public int IdCargo { get; set; }
        public Cargo? Cargo { get; set; } = default!;
    }
}
