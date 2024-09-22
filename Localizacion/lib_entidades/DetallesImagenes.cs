using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_entidades
{
    public class DetallesImagenes
    {
        public int Id {  get; set; }
        public string? Autor {  get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string? Detalles {  get; set; }
    }
}
