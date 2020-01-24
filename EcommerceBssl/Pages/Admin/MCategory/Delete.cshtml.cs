using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcommerceBssl.Data;
using EcommerceBssl.Models;

namespace EcommerceBssl
{
    public class DeleteModel : PageModel
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;

        public DeleteModel(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Maincategory Maincategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Maincategory = await _context.Maincategories.FirstOrDefaultAsync(m => m.Id == id);

            if (Maincategory == null)
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

            Maincategory = await _context.Maincategories.FindAsync(id);

            if (Maincategory != null)
            {
                _context.Maincategories.Remove(Maincategory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
