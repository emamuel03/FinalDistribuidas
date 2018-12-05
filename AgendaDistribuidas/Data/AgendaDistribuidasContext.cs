using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaDistribuidas.Models
{
    public class AgendaDistribuidasContext : DbContext
    {
        public AgendaDistribuidasContext (DbContextOptions<AgendaDistribuidasContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaDistribuidas.Models.Contacto> Contacto { get; set; }
        public DbSet<AgendaDistribuidas.Models.Sector> Sector { get; set; }
    }
}
