using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_aplicaciones.Interfaces
{
    public interface ILocalizacionesAplicacion
    {
        List<Localizaciones> Listar();
        List<Localizaciones> Buscar(Localizaciones entidad, string tipo);
        Localizaciones Guardar(Localizaciones entidad);
        Localizaciones Modificar(Localizaciones entidad);
        Localizaciones Borrar(Localizaciones entidad);

    }
}
