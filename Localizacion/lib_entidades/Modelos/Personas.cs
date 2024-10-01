using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// libreria para definir los notaciones de campos en la base de datos
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Personas
    {
        [Key] public int Id { get; set; }
        public string Cedula { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
        public bool Activo { get; set; }
    }
}