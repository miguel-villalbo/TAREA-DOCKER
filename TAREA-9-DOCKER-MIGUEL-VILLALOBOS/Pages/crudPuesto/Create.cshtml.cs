using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tarea_9_Docker.Data;

namespace Tarea_9_Docker.Pages.crudPuesto
{
    public class CreateModel : PageModel
    {
        private readonly Tarea_9_Docker.Data.ApplicationDbContext _context;

        public CreateModel(Tarea_9_Docker.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Puesto Puesto { get; set; } = new Puesto();

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Puestos == null || Puesto == null)
            {
                return Page();
            }

            _context.Puestos.Add(Puesto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
