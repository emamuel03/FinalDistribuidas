using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgendaDistribuidas.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaDistribuidas.Controllers
{
    public class HomeController : Controller
    {
        private readonly AgendaDistribuidasContext _context;

        public HomeController(AgendaDistribuidasContext context)
        {
            _context = context;
        }

        // GET: Contactos
        public async Task<IActionResult> Index(string textBusqueda)
        {
            var contactos = from c in _context.Contacto.Include(s=>s.Sector)
                            select c;
            if (!String.IsNullOrEmpty(textBusqueda))
            {
                contactos = contactos.Where(s => s.Nombre.Contains(textBusqueda));
            }
            return View(await contactos.ToListAsync());
        }
    }
}
