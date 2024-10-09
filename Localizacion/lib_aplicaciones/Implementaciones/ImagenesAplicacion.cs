using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_entidades;
using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class ImagenesAplicacion : IImagenesAplicacion
    {
        private readonly iImagenesRepositorio iRepositorio;

        public ImagenesAplicacion(iImagenesRepositorio iRepositorio)
        {
            if (iRepositorio == null)
                throw new ArgumentNullException(nameof(iRepositorio));

            this.iRepositorio = iRepositorio;
        }

        public Imagenes Borrar(Imagenes entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id == 0)
                throw new InvalidOperationException("El pago no ha sido guardado.");

            entidad = iRepositorio.Borrar(entidad);
            return entidad;
        }

        public List<Imagenes> Buscar(Imagenes entidad, string tipo)
        {
            throw new NotImplementedException();
        }

        public Imagenes Guardar(Imagenes entidad)
        {
            if (entidad == null)
                throw new ArgumentException("La entidad no puede ser nula", nameof(entidad));

            if (entidad.Id != 0)
                throw new InvalidOperationException("El pago ya ha sido guardado.");

            //entidad = CalcularPersonas(entidad);
            entidad = iRepositorio.Guardar(entidad);
            return entidad;
        }

        public List<Imagenes> Listar()
        {
            return iRepositorio.Listar();
        }

        public Imagenes Modificar(Imagenes entidad)
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
