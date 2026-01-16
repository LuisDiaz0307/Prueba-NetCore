using Microsoft.EntityFrameworkCore;
using Practica__asp.net.Data;
using Practica__asp.net.Models;

namespace Practica__asp.net.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Mira si ya hay datos
                if (context.Servicios.Any())
                {
                    return;   // La base de datos ya tiene datos, no hace nada
                }

                context.Servicios.AddRange(
                    new BaseDatos { Nombre = "Soporte Técnico Nivel 1", Descripcion = "Asistencia básica remota", FechaRegistro = DateTime.Now.AddDays(-30) },
                    new BaseDatos { Nombre = "Mantenimiento Servidores", Descripcion = "Limpieza y actualización de racks", FechaRegistro = DateTime.Now.AddDays(-29) },
                    new BaseDatos { Nombre = "Desarrollo Web Frontend", Descripcion = "Creación de interfaces con React", FechaRegistro = DateTime.Now.AddDays(-28) },
                    new BaseDatos { Nombre = "Consultoría IT", Descripcion = "Asesoría en transformación digital", FechaRegistro = DateTime.Now.AddDays(-27) },
                    new BaseDatos { Nombre = "Seguridad Informática", Descripcion = "Análisis de vulnerabilidades", FechaRegistro = DateTime.Now.AddDays(-26) },
                    new BaseDatos { Nombre = "Redes y Cableado", Descripcion = "Instalación de fibra óptica", FechaRegistro = DateTime.Now.AddDays(-25) },
                    new BaseDatos { Nombre = "Backup en la Nube", Descripcion = "Configuración de copias de seguridad", FechaRegistro = DateTime.Now.AddDays(-24) },
                    new BaseDatos { Nombre = "Reparación Laptops", Descripcion = "Cambio de pantallas y teclados", FechaRegistro = DateTime.Now.AddDays(-23) },
                    new BaseDatos { Nombre = "Desarrollo Backend", Descripcion = "APIs con .NET 9", FechaRegistro = DateTime.Now.AddDays(-22) },
                    new BaseDatos { Nombre = "Auditoría de Software", Descripcion = "Revisión de licencias", FechaRegistro = DateTime.Now.AddDays(-21) },
                    // ... (puedes repetir o agregar más hasta llegar a 30)
                    new BaseDatos { Nombre = "Instalación de Cámaras", Descripcion = "Sistemas CCTV IP", FechaRegistro = DateTime.Now.AddDays(-20) },
                    new BaseDatos { Nombre = "Gestión de Bases de Datos", Descripcion = "Optimización de queries SQL", FechaRegistro = DateTime.Now.AddDays(-19) },
                    new BaseDatos { Nombre = "Diseño UI/UX", Descripcion = "Prototipado en Figma", FechaRegistro = DateTime.Now.AddDays(-18) },
                    new BaseDatos { Nombre = "Marketing Digital", Descripcion = "Campañas de SEO y SEM", FechaRegistro = DateTime.Now.AddDays(-17) },
                    new BaseDatos { Nombre = "Soporte Presencial", Descripcion = "Visita técnica a oficinas", FechaRegistro = DateTime.Now.AddDays(-16) },
                    new BaseDatos { Nombre = "Configuración de Azure", Descripcion = "Despliegue de Web Apps", FechaRegistro = DateTime.Now.AddDays(-15) },
                    new BaseDatos { Nombre = "Ciberseguridad Proactiva", Descripcion = "Firewalls y Antivirus", FechaRegistro = DateTime.Now.AddDays(-14) },
                    new BaseDatos { Nombre = "Venta de Hardware", Descripcion = "Suministro de periféricos", FechaRegistro = DateTime.Now.AddDays(-13) },
                    new BaseDatos { Nombre = "Formación IT", Descripcion = "Cursos de Office 365", FechaRegistro = DateTime.Now.AddDays(-12) },
                    new BaseDatos { Nombre = "Desarrollo de Apps", Descripcion = "Aplicaciones con Flutter", FechaRegistro = DateTime.Now.AddDays(-11) },
                    new BaseDatos { Nombre = "Mantenimiento Impresoras", Descripcion = "Limpieza de cabezales", FechaRegistro = DateTime.Now.AddDays(-10) },
                    new BaseDatos { Nombre = "Voz sobre IP (VoIP)", Descripcion = "Configuración de telefonía", FechaRegistro = DateTime.Now.AddDays(-9) },
                    new BaseDatos { Nombre = "E-commerce Setup", Descripcion = "Tiendas en Shopify", FechaRegistro = DateTime.Now.AddDays(-8) },
                    new BaseDatos { Nombre = "Hosting Dedicado", Descripcion = "Administración de VPS", FechaRegistro = DateTime.Now.AddDays(-7) },
                    new BaseDatos { Nombre = "Data Analytics", Descripcion = "Reportes con Power BI", FechaRegistro = DateTime.Now.AddDays(-6) },
                    new BaseDatos { Nombre = "Automatización Industrial", Descripcion = "Programación de PLC", FechaRegistro = DateTime.Now.AddDays(-5) },
                    new BaseDatos { Nombre = "Recuperación de Datos", Descripcion = "Fallas en discos duros", FechaRegistro = DateTime.Now.AddDays(-4) },
                    new BaseDatos { Nombre = "Virtualización", Descripcion = "Entornos con VMware", FechaRegistro = DateTime.Now.AddDays(-3) },
                    new BaseDatos { Nombre = "Migración a la Nube", Descripcion = "De On-premise a AWS", FechaRegistro = DateTime.Now.AddDays(-2) },
                    new BaseDatos { Nombre = "Soporte Especializado", Descripcion = "Consultas de arquitectura", FechaRegistro = DateTime.Now.AddDays(-1) }
                );
                context.SaveChanges();
            }
        }
    }
}