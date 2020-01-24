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
    public class IndexModel : PageModel
    {
        private readonly EcommerceBssl.Data.ApplicationDbContext _context;

        public IndexModel(EcommerceBssl.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Maincategory> Maincategory { get;set; }

        public async Task OnGetAsync()
        {
            Maincategory = await _context.Maincategories.ToListAsync();
        }
    }
}
