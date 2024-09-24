using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IUbicacionesRepositorio
    {
        void Configurar(string string_conexion);
        List<Ubicaciones> Listar();
        List<Ubicaciones> Buscar(Expression<Func<Ubicaciones, bool>> condiciones);
        Ubicaciones Guardar(Ubicaciones entidad);
        Ubicaciones Modificar(Ubicaciones entidad);
        Ubicaciones Borrar(Ubicaciones entidad);
        bool Existe(Expression<Func<Ubicaciones, bool>> condiciones);
    }
}
