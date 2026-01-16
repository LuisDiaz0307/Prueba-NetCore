namespace Practica_asp.net.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Correo {  get; set; }

        public string Clave { get; set; }

    }
}
