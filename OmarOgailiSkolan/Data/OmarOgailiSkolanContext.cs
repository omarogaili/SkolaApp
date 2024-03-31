using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OmarOgailiSkolan;

namespace OmarOgailiSkolan.Data
{
    public class OmarOgailiSkolanContext : DbContext
    {
        public OmarOgailiSkolanContext (DbContextOptions<OmarOgailiSkolanContext> options)
            : base(options)
        {
        }

        public DbSet<OmarOgailiSkolan.Application> Application { get; set; } = default!;
    }
}
