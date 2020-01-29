﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EcommerceBssl.Data;
using EcommerceBssl.Models;
using Microsoft.AspNetCore.Http;
using EcommerceBssl.UtilityMethods;

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
        [BindProperty]
        public List<IFormFile> ProductImages { get; set; }
        //public List<IFormFile> ProductImages { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           // Product.Description = "new descriptiuon";    for flaging or updating colums

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            var prdId = Product.Id;
            var images = new List<Image>();
            foreach(var img in ProductImages)
            {
                if(img !=null && img.Length > 0)
                {
                    var filepath = await FileUpload.UploadFile(img,"productimages");
                    images.Add(new Image { Link = filepath, ProductId = prdId });
                }
            }
            _context.Images.AddRange(images);
             await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}