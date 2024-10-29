using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Imagenes
    {
        [Key] public int Id { get; set; }
        public string Url { get; set; } = null!;
    }
}