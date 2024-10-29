using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IPersonasAplicacion
    {
        void Configurar(string string_conexion);

        List<Personas> Listar();

        List<Personas> Buscar(Personas entidad, string tipo);

        Personas Guardar(Personas entidad);

        Personas Modificar(Personas entidad);

        Personas Borrar(Personas entidad);
    }
}