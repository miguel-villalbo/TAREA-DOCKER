using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tarea_9_Docker.Data;

namespace Tarea_9_Docker.Pages.crudEmpleado
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && _context.Empleados != null && Empleado != null)
            {
                _context.Empleados.Add(Empleado);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
