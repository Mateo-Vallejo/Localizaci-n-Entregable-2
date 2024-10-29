using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class LocalizacionesAplicacion : ILocalizacionesAplicacion
    {
        private readonly ILocalizacionesRepositorio iRepositorio;

        public LocalizacionesAplicacion(ILocalizacionesRepositorio iRepositorio)
        {
            if (iRepositorio == null)
                throw new ArgumentNullException(nameof(iRepositorio));

            this.iRepositorio = iRepositorio;
        }

        public Localizaciones Borrar(Localizaciones entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Borrar(entidad);
            return entidad;
        }

        public List<Localizaciones> Buscar(Localizaciones entidad, string tipo)
        {
            throw new NotImplementedException();
        }

        public Localizaciones Guardar(Localizaciones entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id != 0)
                throw new InvalidOperationException("El pago ya ha sido guardado.");

            //entidad = CalcularPersonas(entidad);
            entidad = iRepositorio.Guardar(entidad);
            return entidad;
        }

        public List<Localizaciones> Listar()
        {
            return iRepositorio.Listar();
        }

        public Localizaciones Modificar(Localizaciones entidad)
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