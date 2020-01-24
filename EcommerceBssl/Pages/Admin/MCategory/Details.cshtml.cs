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
    public class DetailsModel : PageModel
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;

        public DetailsModel(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
