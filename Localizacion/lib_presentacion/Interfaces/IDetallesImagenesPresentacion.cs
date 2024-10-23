using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IDetallesImagenesPresentacion
    {
        Task<List<DetallesImagenes>> Listar();
        Task<List<DetallesImagenes>> Buscar(DetallesImagenes entidad, string tipo);
        Task<DetallesImagenes> Guardar(DetallesImagenes entidad);
        Task<DetallesImagenes> Modificar(DetallesImagenes entidad);
        Task<DetallesImagenes> Borrar(DetallesImagenes entidad);

    }
}
