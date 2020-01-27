﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceBssl.Data;
using EcommerceBssl.Models;

namespace EcommerceBssl.Pages.Admin.Products
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
        ViewData["SubCategoryId"] = new SelectList(_context.SubCategories, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           // Product.Description = "new descriptiuon";    for flaging or updating colums

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}