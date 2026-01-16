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


        // --- EDITAR (GET): Busca el registro y muestra el formulario ---
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var servicio = await _context.Servicios.FindAsync(id);
            if (servicio == null) return NotFound();
            return View(servicio);
        }

        // --- EDITAR (POST): Guarda los cambios ---
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BaseDatos modelo)
        {
            if (id != modelo.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // --- ELIMINAR (GET): Pregunta si estás seguro ---
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var servicio = await _context.Servicios.FirstOrDefaultAsync(m => m.Id == id);
            if (servicio == null) return NotFound();
            return View(servicio);
        }

        // --- ELIMINAR (POST): Borra el registro definitivamente ---
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicio = await _context.Servicios.FindAsync(id);
            if (servicio != null) _context.Servicios.Remove(servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // GET: BaseDatos
        public async Task<IActionResult> Index(string buscar, int pagina = 1)
        {
            // Definimos cuántos registros queremos por página
            int registrosPorPagina = 10;

            // 1. Preparamos la consulta (LINQ to Entities)
            var consulta = from s in _context.Servicios select s;

            // 2. Filtramos (Tu ruta eficiente y profesional con EF.Functions)
            if (!string.IsNullOrEmpty(buscar))
            {
                string termino = $"%{buscar}%";
                consulta = consulta.Where(s =>
                    EF.Functions.Like(s.Nombre, termino) ||
                    EF.Functions.Like(s.Descripcion, termino));
            }

            // 3. Ordenamos
            consulta = consulta.OrderByDescending(s => s.Id);

            // --- NUEVA LÓGICA DE PAGINACIÓN ---

            // Contamos el total de registros filtrados (necesario para saber cuántas páginas habrá)
            int totalRegistros = await consulta.CountAsync();

            // Ejecutamos la consulta final aplicando el "salto" y el "límite"
            var resultados = await consulta
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToListAsync();

            // Calculamos el total de páginas (ej. 30 registros / 10 = 3 páginas)
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            ViewBag.PaginaActual = pagina;
            ViewData["FiltroActual"] = buscar;

            // 4. Enviamos solo los 10 resultados de la página actual a la vista
            return View(resultados);
        }




    }
}