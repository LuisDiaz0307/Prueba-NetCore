using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica_asp.net.Data;
using Practica_asp.net.Models;

namespace Practica_asp.net.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios/Index
        public async Task<IActionResult> Index(string buscar, int pagina = 1)
        {
            int registrosPorPagina = 10;

            // 1. Preparamos la consulta
            var consulta = from u in _context.Usuarios select u;

            // 2. Filtramos con EF.Functions (Optimizado)
            if (!string.IsNullOrEmpty(buscar))
            {
                string termino = $"%{buscar}%";
                consulta = consulta.Where(u =>
                    EF.Functions.Like(u.Name, termino) ||
                    EF.Functions.Like(u.Correo, termino));
            }

            // 3. Ordenamos (Por ID descendente como en BaseDatos o por Nombre)
            consulta = consulta.OrderByDescending(u => u.Id);

            // 4. Lógica de Paginación
            int totalRegistros = await consulta.CountAsync();

            var resultados = await consulta
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina)
                .ToListAsync();

            // 5. Variables para la vista
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            ViewBag.PaginaActual = pagina;
            ViewBag.Buscar = buscar; // Usamos ViewBag.Buscar para la vista que diseñamos

            return View(resultados);
        }

        // --- CREAR ---
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelo);
        }

        // --- EDITAR ---
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null) return NotFound();
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Usuario modelo)
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

        // --- ELIMINAR ---
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null) _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}