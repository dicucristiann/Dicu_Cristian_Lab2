﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dicu_Cristian_Lab2.Data;
using Dicu_Cristian_Lab2.Models;

namespace Dicu_Cristian_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Dicu_Cristian_Lab2.Data.Dicu_Cristian_Lab2Context _context;

        public CreateModel(Dicu_Cristian_Lab2.Data.Dicu_Cristian_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "ID", "ID");
        ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public BookCategory BookCategory { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BookCategory == null || BookCategory == null)
            {
                return Page();
            }

            _context.BookCategory.Add(BookCategory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
