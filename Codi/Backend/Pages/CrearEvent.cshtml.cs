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
    public class CrearEventModel : PageModel
    {
        private readonly Backend.Data.AppDbContext _context;

        public CrearEventModel(Backend.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EstablimentId"] = new SelectList(_context.Establiments, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Events.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
