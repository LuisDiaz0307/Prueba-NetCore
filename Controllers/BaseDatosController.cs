using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica__asp.net.Data;
using Practica__asp.net.Models;

namespace Practica__asp.net.Controllers
{
    public class BaseDatosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BaseDatosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Listado de registros (Index)
        public async Task<IActionResult> Index()
        {
            return View(await _context.Servicios.ToListAsync());
        }

        // Pantalla para crear (GET)
        public IActionResult Create()
        {
            return View();
        }

        // Guardar el registro (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BaseDatos modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }
    }
}