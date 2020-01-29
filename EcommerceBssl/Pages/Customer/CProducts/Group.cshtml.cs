using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceBssl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBssl.Pages.Customer.CProducts
{
    public class GroupModel : PageModel
    { //dependence injector
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;
        public GroupModel(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public SubCategory subCategory { get; set; }
        public async Task<IActionResult> OnGetAsync(int? sgid)
        { 
            if(sgid != null)
            {
                //get the subcategory that 
                subCategory = await _context.SubCategories.Include
                    (m => m.Product).ThenInclude(l => l.Images)
                    .FirstOrDefaultAsync(n => n.Id == sgid.Value);
              
                return Page();
            }
            else
            {
                return NotFound();
            }
        }
    }
}