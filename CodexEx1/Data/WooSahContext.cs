using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodexEx1.Models
{
    public class WooSahContext : DbContext
    {
        public WooSahContext (DbContextOptions<WooSahContext> options)
            : base(options)
        {
        }

        public DbSet<CodexEx1.Models.WooSahPOCOModel> WooSahPOCOModel { get; set; }
    }
}
