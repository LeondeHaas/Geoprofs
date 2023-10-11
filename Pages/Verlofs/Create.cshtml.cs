using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using Verlofsysteem.Data;

namespace Verlofsysteem.Pages.Verlofs
{
    public class CreateModel : PageModel
    {
        private readonly Verlofsysteem.Data.VerlofsysteemContext _context;

        public CreateModel(Verlofsysteem.Data.VerlofsysteemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public VerlofModel VerlofModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.VerlofModel == null || VerlofModel == null)
            {
                return Page();
            }

            _context.VerlofModel.Add(VerlofModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
