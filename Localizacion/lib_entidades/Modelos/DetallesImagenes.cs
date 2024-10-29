using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class DetallesImagenes
    {
        [Key] public int Id { get; set; }
        public string Autor { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Detalles { get; set; } = null!;
        public bool Activo { get; set; }
    }
}