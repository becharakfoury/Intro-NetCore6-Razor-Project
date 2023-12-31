﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abyweb.Data;
using Abyweb.Model;

namespace Abyweb.Pages.ScafoldingCategories
{
    public class IndexModel : PageModel
    {
        private readonly Abyweb.Data.ApplicationDbContext _context;

        public IndexModel(Abyweb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category_Db != null)
            {
                Category = await _context.Category_Db.ToListAsync();
            }
        }
    }
}
