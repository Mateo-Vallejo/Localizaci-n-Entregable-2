using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Ubicaciones
    {
        public int Id { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
