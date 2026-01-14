using Microsoft.EntityFrameworkCore;
using Practica__asp.net.Models; // Esto conecta con tu carpeta de Modelos

namespace Practica__asp.net.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Esta propiedad se convertirá en tu tabla de base de datos
        public DbSet<BaseDatos> Servicios { get; set; }
    }
}