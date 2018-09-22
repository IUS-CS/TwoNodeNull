using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Brewskii.Models;

namespace Brewskii.Pages.Beers
{
    public class DeleteModel : PageModel
    {
        private readonly Brewskii.Models.BrewskiiContext _context;

        public DeleteModel(Brewskii.Models.BrewskiiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Beer Beer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beer = await _context.Beer.FirstOrDefaultAsync(m => m.ID == id);

            if (Beer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beer = await _context.Beer.FindAsync(id);

            if (Beer != null)
            {
                _context.Beer.Remove(Beer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
