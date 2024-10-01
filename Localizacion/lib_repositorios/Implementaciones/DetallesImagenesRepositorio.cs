using lib_repositorios.Interfaces;
using lib_entidades;
using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class DetallesImagenesRepositorio : IDetallesImagenesRepositorio
    {
        private Conexion? conexion;

        public DetallesImagenesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<DetallesImagenes> Listar()
        {
            return conexion!.Listar<DetallesImagenes>();
        }

        public List<DetallesImagenes> Buscar(Expression<Func<DetallesImagenes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public DetallesImagenes Guardar(DetallesImagenes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public DetallesImagenes Modificar(DetallesImagenes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public DetallesImagenes Borrar(DetallesImagenes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<DetallesImagenes, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
