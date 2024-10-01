using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Localidades
    {
        [Key] public int Id { get; set; }
        public string Pais { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string CodigoPostal { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Calle { get; set; } = null!;

    }
}
