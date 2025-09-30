using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Backend.Pages
{
    public class MapAddressModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public string Address { get; set; }
        public IActionResult OnPost()
        {
            // Address ja conté el valor del form
            return Page();
        }

    }
}
