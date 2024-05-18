using HRManagerWEB.Data;
using HRManagerWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HRManagerWEB.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly HRManagerContext _context;

        public IndexModel(HRManagerContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleados { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Empleados != null)
            {
                Empleados = await _context.Empleados.ToListAsync();
            }
        }
    }
}
