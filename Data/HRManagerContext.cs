using HRManagerWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace HRManagerWEB.Data
{
    public class HRManagerContext: DbContext
    {
        public HRManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Nomina> Nominas { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=HRManager;Trusted_Connection=True;");
        }
    }
}
