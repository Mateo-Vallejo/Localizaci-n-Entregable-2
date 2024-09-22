using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class DetallesImagenes
    {
        public int Id {  get; set; }
        public string Autor {  get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Detalles {  get; set; } = null!;
    }
}
