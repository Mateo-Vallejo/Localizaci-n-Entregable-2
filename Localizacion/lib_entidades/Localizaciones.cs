using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Localizaciones
    {
        public int Id { get; set; }
        public Personas personas { get; set; } = null!;
        public Ubicaciones ubicaciones { get; set; } = null!;
        public Localidades localidades { get; set; } = null!;
        public Imagenes imagenes { get; set; } = null!;
        public DetallesImagenes detalles { get; set; } = null!;
        public TimeSpan Hora { get; set; }
    }
}
