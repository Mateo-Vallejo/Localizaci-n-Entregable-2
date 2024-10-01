using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface ILocalidadesAplicacion
    {
        List<Localidades> Listar();
        List<Localidades> Buscar(Localidades entidad, string tipo);
        Localidades Guardar(Localidades entidad);
        Localidades Modificar(Localidades entidad);
        Localidades Borrar(Localidades entidad);

    }
}
