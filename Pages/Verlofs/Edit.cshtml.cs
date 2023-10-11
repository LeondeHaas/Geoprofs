using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using Verlofsysteem.Data;

namespace Verlofsysteem.Pages.Verlofs
{
    public class EditModel : PageModel
    {
        private readonly Verlofsysteem.Data.VerlofsysteemContext _context;

        public EditModel(Verlofsysteem.Data.VerlofsysteemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public VerlofModel VerlofModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.VerlofModel == null)
            {
                return NotFound();
            }

            var verlofmodel =  await _context.VerlofModel.FirstOrDefaultAsync(m => m.Id == id);
            if (verlofmodel == null)
            {
                return NotFound();
            }
            VerlofModel = verlofmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VerlofModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerlofModelExists(VerlofModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VerlofModelExists(int id)
        {
          return (_context.VerlofModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
