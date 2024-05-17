using System.ComponentModel.DataAnnotations;

namespace HRManagerWEB.Models
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }
        public string TituloCargo { get; set; }
        public string? Descripcion { get; set; }
    }
}
