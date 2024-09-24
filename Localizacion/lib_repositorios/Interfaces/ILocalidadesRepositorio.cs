using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface ILocalidadesRepositorio
    {
        void Configurar(string string_conexion);
        List<Localidades> Listar();
        List<Localidades> Buscar(Expression<Func<Localidades, bool>> condiciones);
        Localidades Guardar(Localidades entidad);
        Localidades Modificar(Localidades entidad);
        Localidades Borrar(Localidades entidad);
        bool Existe(Expression<Func<Localidades, bool>> condiciones);
    }
}
