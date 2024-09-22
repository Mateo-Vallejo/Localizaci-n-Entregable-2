using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_entidades
{
    public class Personas
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }

    }
}
