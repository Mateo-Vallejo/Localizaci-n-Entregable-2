using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface IUbicacionesAplicacion
    {
        List<Ubicaciones> Listar();
        List<Ubicaciones> Buscar(Ubicaciones entidad, string tipo);
        Ubicaciones Guardar(Ubicaciones entidad);
        Ubicaciones Modificar(Ubicaciones entidad);
        Ubicaciones Borrar(Ubicaciones entidad);

    }
}
