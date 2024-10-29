using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Ubicaciones
    {
        [Key] public int Id { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }

        public bool Activo { get; set; }
    }
}