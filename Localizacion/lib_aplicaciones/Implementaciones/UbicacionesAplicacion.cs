using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class UbicacionesAplicacion : IUbicacionesAplicacion
    {
        private readonly IUbicacionesRepositorio iRepositorio;

        public UbicacionesAplicacion(IUbicacionesRepositorio iRepositorio)
        {
            if (iRepositorio == null)
                throw new ArgumentNullException(nameof(iRepositorio));

            this.iRepositorio = iRepositorio;
        }

        public Ubicaciones Borrar(Ubicaciones entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Borrar(entidad);
            return entidad;
        }

        public List<Ubicaciones> Buscar(Ubicaciones entidad, string tipo)
        {
            throw new NotImplementedException();
        }

        public Ubicaciones Guardar(Ubicaciones entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id != 0)
                throw new InvalidOperationException("El pago ya ha sido guardado.");

            //entidad = CalcularPersonas(entidad);
            entidad = iRepositorio.Guardar(entidad);
            return entidad;
        }

        public List<Ubicaciones> Listar()
        {
            return iRepositorio.Listar();
        }

        public Ubicaciones Modificar(Ubicaciones entidad)
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