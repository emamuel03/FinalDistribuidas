using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDistribuidas.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public int Interno { get; set; }
        public string Nombre { get; set; }
        public int SectorId { get; set; }

        public Sector Sector { get; set; }
    }
}
