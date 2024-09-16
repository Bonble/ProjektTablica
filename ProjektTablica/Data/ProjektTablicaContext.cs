using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektTablica.Models;

namespace ProjektTablica.Data
{
    public class ProjektTablicaContext : DbContext
    {
        public ProjektTablicaContext (DbContextOptions<ProjektTablicaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjektTablica.Models.Ogloszenie> Ogloszenie { get; set; } = default!;
    }
}
