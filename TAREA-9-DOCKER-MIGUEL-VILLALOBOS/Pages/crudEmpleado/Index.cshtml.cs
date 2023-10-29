using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tarea_9_Docker.Data;

namespace Tarea_9_Docker.Pages.crudEmpleado
{
    public class IndexModel : PageModel
    {
        private readonly Tarea_9_Docker.Data.ApplicationDbContext _context;

        public IndexModel(Tarea_9_Docker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Empleado> Empleados { get; set; } = new List<Empleado>();

        public async Task OnGetAsync()
        {
            if (_context.Empleados != null)
            {
                Empleados = await _context.Empleados.ToListAsync();
            }
        }
    }
}
