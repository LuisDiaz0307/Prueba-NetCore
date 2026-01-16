using Microsoft.EntityFrameworkCore;
using Practica_asp.net.Models; // Esto conecta con tu carpeta de Modelos

namespace Practica_asp.net.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Esta propiedad se convertirá en tu tabla de base de datos
        public DbSet<BaseDatos> Servicios { get; set; }
    // AGREGA ESTA LÍNEA: Esto creará la tabla de Usuarios en SQL
        public DbSet<Usuario> Usuarios { get; set; }
    }
}