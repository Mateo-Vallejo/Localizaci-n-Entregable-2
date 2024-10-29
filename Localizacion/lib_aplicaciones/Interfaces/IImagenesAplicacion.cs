using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IImagenesAplicacion
    {
        void Configurar(string string_conexion);

        List<Imagenes> Listar();

        List<Imagenes> Buscar(Imagenes entidad, string tipo);

        Imagenes Guardar(Imagenes entidad);

        Imagenes Modificar(Imagenes entidad);

        Imagenes Borrar(Imagenes entidad);
    }
}