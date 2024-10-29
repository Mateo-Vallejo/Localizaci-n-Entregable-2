using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class ImagenesRepositorio : iImagenesRepositorio
    {
        private Conexion? conexion;

        public ImagenesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Imagenes> Listar()
        {
            return conexion!.Listar<Imagenes>();
        }

        public List<Imagenes> Buscar(Expression<Func<Imagenes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Imagenes Guardar(Imagenes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Imagenes Modificar(Imagenes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Imagenes Borrar(Imagenes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Imagenes, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}