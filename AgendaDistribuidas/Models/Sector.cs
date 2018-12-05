using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDistribuidas.Models
{
    public class Sector
    {
        public int SectorId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Contacto> Contactos { get; set; }
    }
}
