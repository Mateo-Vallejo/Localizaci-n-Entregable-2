using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface ILocalizacionesRepositorio
    {
        void Configurar(string string_conexion);
        List<Localizaciones> Listar();
        List<Localizaciones> Buscar(Expression<Func<Localizaciones, bool>> condiciones);
        Localizaciones Guardar(Localizaciones entidad);
        Localizaciones Modificar(Localizaciones entidad);
        Localizaciones Borrar(Localizaciones entidad);
        bool Existe(Expression<Func<Localizaciones, bool>> condiciones);
    }
}
