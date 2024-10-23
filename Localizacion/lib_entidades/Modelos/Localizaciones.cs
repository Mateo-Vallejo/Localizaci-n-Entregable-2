using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using lib_entidades.Modelos;

namespace lib_entidades.Modelos
{
    public class Localizaciones
    {
        [Key] public int Id { get; set; }
        public int personas { get; set; }
        public int localidades { get; set; } 
        public int ubicaciones { get; set; } 
        public int imagenes { get; set; } 
        public int detalles { get; set; } 
        public TimeSpan Hora { get; set; }
        public bool Activo { get; set; }
    }
}
