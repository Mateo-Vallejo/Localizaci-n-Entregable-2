using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class PersonasAplicacion : IPersonasAplicacion
    {
        private readonly IPersonasRepositorio iRepositorio;

        public PersonasAplicacion(IPersonasRepositorio iRepositorio)
        {
            if (iRepositorio == null)
                throw new ArgumentNullException(nameof(iRepositorio));

            this.iRepositorio = iRepositorio;
        }

        public Personas Borrar(Personas entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Borrar(entidad);
            return entidad;
        }

        public List<Personas> Buscar(Personas entidad, string tipo)
        {
            throw new NotImplementedException();
        }

        public Personas Guardar(Personas entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id != 0)
                throw new InvalidOperationException("El pago ya ha sido guardado.");

            //entidad = CalcularPersonas(entidad);
            entidad = iRepositorio.Guardar(entidad);
            return entidad;
        }

        public List<Personas> Listar()
        {
            return iRepositorio.Listar();
        }

        public Personas Modificar(Personas entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Modificar(entidad);
            return entidad;
        }
    }
}