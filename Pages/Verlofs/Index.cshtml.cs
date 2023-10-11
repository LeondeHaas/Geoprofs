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
    public class IndexModel : PageModel
    {
        private readonly Verlofsysteem.Data.VerlofsysteemContext _context;

        public IndexModel(Verlofsysteem.Data.VerlofsysteemContext context)
        {
            _context = context;
        }

        public IList<VerlofModel> VerlofModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.VerlofModel != null)
            {
                VerlofModel = await _context.VerlofModel.ToListAsync();
            }
        }
    }
}
