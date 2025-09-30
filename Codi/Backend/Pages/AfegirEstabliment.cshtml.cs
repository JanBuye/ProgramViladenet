using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Pages
{
    public class AfegirEstablimentModel : PageModel
    {
        private readonly AppDbContext _context;

        public AfegirEstablimentModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Establiment Establiment { get; set; }

        [BindProperty]
        public Ubicacio Ubicacio { get; set; }

        public List<Client> Clients { get; set; }

        // GET -> Quan entres a la pàgina
        public async Task OnGetAsync()
        {
            Clients = await _context.Clients.ToListAsync();
        }

        // POST -> Quan envies el formulari
        public async Task<IActionResult> OnPostAsync(int clientId)
        {
            // Tornem a carregar els clients per si hem de re-renderitzar la pàgina
            Clients = await _context.Clients.ToListAsync();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Guardem Ubicació
            _context.Ubicacions.Add(Ubicacio);
            await _context.SaveChangesAsync();

            // Relacionem l'establiment amb el client i la ubicació
            Establiment.ClientId = clientId;
            Establiment.UbicacioId = Ubicacio.Id;
            
            _context.Establiments.Add(Establiment);
            await _context.SaveChangesAsync();
            // Tornem a la llista d'establiments
            return RedirectToPage("Index");
        }
    }
}
