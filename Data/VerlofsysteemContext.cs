using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace Verlofsysteem.Data
{
    public class VerlofsysteemContext : DbContext
    {
        public VerlofsysteemContext (DbContextOptions<VerlofsysteemContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.VerlofModel> VerlofModel { get; set; } = default!;
    }
}
