using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_entidades
{
    public class Localizacion
    {
        public int Id { get; set; }
        public Personas personas { get; set; }
        public Ubicaciones ubicaciones { get; set; }
        public Localidades localidades { get; set; }
        public Imagenes imagenes { get; set; } 
        public DetallesImagenes detalles { get; set; }
    }
}
