using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDistribuidas.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        [Required(ErrorMessage ="Debe ingresar un número de Interno")]
        [Range(10,9999,ErrorMessage ="El numero de interno tiene que ser entre 10 y 9999")]
        public int Interno { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre no puede estar vacio.")]
        public string Nombre { get; set; }
        public int SectorId { get; set; }

        public Sector Sector { get; set; }
    }
}
