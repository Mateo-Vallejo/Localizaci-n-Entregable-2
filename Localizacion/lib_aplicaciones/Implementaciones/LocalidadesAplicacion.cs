
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_entidades;
using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class LocalidadesAplicacion : ILocalidadesAplicacion
    {
        private readonly ILocalidadesRepositorio iRepositorio;

        public LocalidadesAplicacion(ILocalidadesRepositorio iRepositorio)
        {
            if (iRepositorio == null)
                throw new ArgumentNullException(nameof(iRepositorio));

            this.iRepositorio = iRepositorio;
        }

        public Localidades Borrar(Localidades entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Borrar(entidad);
            return entidad;
        }

        public List<Localidades> Buscar(Localidades entidad, string tipo)
        {
            throw new NotImplementedException();
        }

        public Localidades Guardar(Localidades entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id != 0)
                throw new InvalidOperationException("El pago ya ha sido guardado.");

            //entidad = CalcularPersonas(entidad);
            entidad = iRepositorio.Guardar(entidad);
            return entidad;
        }

        public List<Localidades> Listar()
        {
            return iRepositorio.Listar();
        }

        public Localidades Modificar(Localidades entidad)
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
