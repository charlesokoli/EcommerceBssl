using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcommerceBssl.Data;
using EcommerceBssl.Models;

namespace EcommerceBssl
{
    public class EditModel : PageModel
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;

        public EditModel(EcommerceBssl.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Maincategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaincategoryExists(Maincategory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MaincategoryExists(int id)
        {
            return _context.Maincategories.Any(e => e.Id == id);
        }
    }
}
