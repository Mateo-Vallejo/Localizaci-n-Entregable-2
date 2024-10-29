using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ILocalidadesAplicacion
    {
        void Configurar(string string_conexion);

        List<Localidades> Listar();

        List<Localidades> Buscar(Localidades entidad, string tipo);

        Localidades Guardar(Localidades entidad);

        Localidades Modificar(Localidades entidad);

        Localidades Borrar(Localidades entidad);
    }
}