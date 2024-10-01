using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IDetallesImagenesAplicacion
    {
        List<DetallesImagenes> Listar();
        List<DetallesImagenes> Buscar(DetallesImagenes entidad, string tipo);
        DetallesImagenes Guardar(DetallesImagenes entidad);
        DetallesImagenes Modificar(DetallesImagenes entidad);
        DetallesImagenes Borrar(DetallesImagenes entidad);

    }
}
