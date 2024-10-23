using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ILocalizacionesPresentacion
    {
        Task<List<Localizaciones>> Listar();
        Task<List<Localizaciones>> Buscar(Localizaciones entidad, string tipo);
        Task<Localizaciones> Guardar(Localizaciones entidad);
        Task<Localizaciones> Modificar(Localizaciones entidad);
        Task<Localizaciones> Borrar(Localizaciones entidad);

    }
}
