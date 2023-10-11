using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using Verlofsysteem.Data;

namespace Verlofsysteem.Pages.Verlofs
{
    public class DetailsModel : PageModel
    {
        private readonly Verlofsysteem.Data.VerlofsysteemContext _context;

        public DetailsModel(Verlofsysteem.Data.VerlofsysteemContext context)
        {
            _context = context;
        }

      public VerlofModel VerlofModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VerlofModel == null)
            {
                return NotFound();
            }

            var verlofmodel = await _context.VerlofModel.FirstOrDefaultAsync(m => m.Id == id);
            if (verlofmodel == null)
            {
                return NotFound();
            }
            else 
            {
                VerlofModel = verlofmodel;
            }
            return Page();
        }
    }
}
