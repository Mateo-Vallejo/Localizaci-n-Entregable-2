using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ILocalidadesPresentacion
    {
        Task<List<Localidades>> Listar();
        Task<List<Localidades>> Buscar(Localidades entidad, string tipo);
        Task<Localidades> Guardar(Localidades entidad);
        Task<Localidades> Modificar(Localidades entidad);
        Task<Localidades> Borrar(Localidades entidad);

    }
}
