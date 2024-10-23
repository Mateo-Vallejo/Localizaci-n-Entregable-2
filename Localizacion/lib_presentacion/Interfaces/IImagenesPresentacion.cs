using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IImagenesPresentacion
    {
        Task<List<Imagenes>> Listar();
        Task<List<Imagenes>> Buscar(Imagenes entidad, string tipo);
        Task<Imagenes> Guardar(Imagenes entidad);
        Task<Imagenes> Modificar(Imagenes entidad);
        Task<Imagenes> Borrar(Imagenes entidad);

    }
}
