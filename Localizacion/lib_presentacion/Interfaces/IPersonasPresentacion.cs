using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IPersonasPresentacion
    {
        Task<List<Personas>> Listar();

        Task<List<Personas>> Buscar(Personas entidad, string tipo);

        Task<Personas> Guardar(Personas entidad);

        Task<Personas> Modificar(Personas entidad);

        Task<Personas> Borrar(Personas entidad);
    }
}