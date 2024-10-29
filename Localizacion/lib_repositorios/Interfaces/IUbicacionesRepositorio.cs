using lib_entidades.Modelos;
using System.Linq.Expressions;

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