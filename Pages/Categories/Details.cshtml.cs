﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dicu_Cristian_Lab2.Data;
using Dicu_Cristian_Lab2.Models;

namespace Dicu_Cristian_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Dicu_Cristian_Lab2.Data.Dicu_Cristian_Lab2Context _context;

        public DetailsModel(Dicu_Cristian_Lab2.Data.Dicu_Cristian_Lab2Context context)
        {
            _context = context;
        }

      public BookCategory BookCategory { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookCategory == null)
            {
                return NotFound();
            }

            var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
            if (bookcategory == null)
            {
                return NotFound();
            }
            else 
            {
                BookCategory = bookcategory;
            }
            return Page();
        }
    }
}
