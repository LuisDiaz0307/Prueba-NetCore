using Microsoft.EntityFrameworkCore;
using Practica_asp.net.Data;
using Practica_asp.net.Models;

namespace Practica_asp.net.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // 1. IMPORTANTE: Cambiamos a context.Usuarios para que coincida con tu DB
                if (context.Usuarios.Any())
                {
                    return;
                }

                context.Usuarios.AddRange(
    new Usuario { Name = "Jose", Correo = "Jose@ejemplo.com", Clave = "123456", FechaNacimiento = new DateOnly(2006, 1, 16) },
    new Usuario { Name = "Manuel", Correo = "Manuel@ejemplo.com", Clave = "123456", FechaNacimiento = new DateOnly(2001, 5, 20) },
    new Usuario { Name = "Pedro", Correo = "Pedro@ejemplo.com", Clave = "123456", FechaNacimiento = new DateOnly(2004, 3, 10) },
    new Usuario { Name = "Juan Pérez", Correo = "juan.perez@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1990, 5, 15) },
    new Usuario { Name = "María García", Correo = "m.garcia@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1985, 8, 22) },
    new Usuario { Name = "Carlos López", Correo = "clopez@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1992, 11, 10) },
    new Usuario { Name = "Ana Martínez", Correo = "ana.mtz@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1995, 3, 30) },
    new Usuario { Name = "Luis Rodríguez", Correo = "lrodriguez@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1988, 12, 5) },
    new Usuario { Name = "Elena Sánchez", Correo = "elena.s@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1993, 7, 18) },
    new Usuario { Name = "Roberto Gómez", Correo = "rgomez@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1982, 1, 25) },
    new Usuario { Name = "Lucía Fernández", Correo = "lucia.f@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1997, 9, 12) },
    new Usuario { Name = "Ricardo Díaz", Correo = "rdiaz@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1990, 4, 8) },
    new Usuario { Name = "Sofía Torres", Correo = "storres@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1994, 6, 21) },
    new Usuario { Name = "Fernando Ruiz", Correo = "fruiz@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1987, 10, 3) },
    new Usuario { Name = "Gabriela Morales", Correo = "g.morales@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1991, 2, 14) },
    new Usuario { Name = "Jorge Herrera", Correo = "jherrera@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1989, 11, 29) },
    new Usuario { Name = "Patricia Castro", Correo = "p.castro@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1996, 5, 5) },
    new Usuario { Name = "Andrés Ortiz", Correo = "aortiz@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1984, 8, 17) },
    new Usuario { Name = "Mónica Silva", Correo = "msilva@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1992, 1, 11) },
    new Usuario { Name = "Diego Ramos", Correo = "dramos@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1995, 12, 24) },
    new Usuario { Name = "Laura Blanco", Correo = "lblanco@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1993, 4, 2) },
    new Usuario { Name = "Héctor Méndez", Correo = "hmendez@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1986, 7, 31) },
    new Usuario { Name = "Silvia Delgado", Correo = "sdelgado@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1991, 10, 15) },
    new Usuario { Name = "Javier Vega", Correo = "jvega@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1983, 6, 9) },
    new Usuario { Name = "Beatriz Soto", Correo = "bsoto@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1994, 3, 27) },
    new Usuario { Name = "Oscar Medina", Correo = "omedina@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1988, 9, 20) },
    new Usuario { Name = "Rosa Guerrero", Correo = "rguerrero@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1990, 2, 1) },
    new Usuario { Name = "Daniel Castillo", Correo = "dcastillo@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1997, 11, 14) },
    new Usuario { Name = "Carmen Peña", Correo = "c.pena@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1985, 5, 29) },
    new Usuario { Name = "Raúl Flores", Correo = "rflores@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1992, 8, 6) },
    new Usuario { Name = "Isabel Navarro", Correo = "inavarro@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1996, 1, 19) },
    new Usuario { Name = "Alberto Cano", Correo = "acano@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1989, 4, 30) },
    new Usuario { Name = "Claudia Rojas", Correo = "crojas@email.com", Clave = "123456", FechaNacimiento = new DateOnly(1994, 7, 7) }
);

                context.SaveChanges();
            }
        }
    }
}