using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IDetallesImagenesAplicacion
    {
        void Configurar(string string_conexion);

        List<DetallesImagenes> Listar();

        List<DetallesImagenes> Buscar(DetallesImagenes entidad, string tipo);

        DetallesImagenes Guardar(DetallesImagenes entidad);

        DetallesImagenes Modificar(DetallesImagenes entidad);

        DetallesImagenes Borrar(DetallesImagenes entidad);
    }
}