using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IUbicacionesPresentacion
    {
        Task<List<Ubicaciones>> Listar();
        Task<List<Ubicaciones>> Buscar(Ubicaciones entidad, string tipo);
        Task<Ubicaciones> Guardar(Ubicaciones entidad);
        Task<Ubicaciones> Modificar(Ubicaciones entidad);
        Task<Ubicaciones> Borrar(Ubicaciones entidad);

    }
}
