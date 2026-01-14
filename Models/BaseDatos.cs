namespace Practica__asp.net.Models
{
    public class BaseDatos
    {
        public int Id { get; set; } // LLave primaria
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}