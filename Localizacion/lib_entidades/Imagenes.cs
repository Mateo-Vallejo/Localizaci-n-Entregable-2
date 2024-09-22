using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Imagenes
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
    }
}
