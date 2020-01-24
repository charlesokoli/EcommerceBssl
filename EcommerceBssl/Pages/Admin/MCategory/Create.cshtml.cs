using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceBssl.Data;
using EcommerceBssl.Models;

namespace EcommerceBssl.Pages.Admin.MCategory
{
    public class CreateModel : PageModel
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;

        public CreateModel(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Maincategory Maincategory { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Maincategories.Add(Maincategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}