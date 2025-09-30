using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Backend.Data;
using Backend.Models;

namespace Backend.Pages
{
    public class AfegirTreballadorModel : PageModel
    {
        private readonly Backend.Data.AppDbContext _context;

        public AfegirTreballadorModel(Backend.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
        ViewData["UbicacioId"] = new SelectList(_context.Ubicacions, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Establiment Establiment { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Establiments.Add(Establiment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
