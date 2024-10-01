using lib_entidades.Modelos;
using lib_entidades;
using System.Linq.Expressions;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class LocalizacionesRepositorio : ILocalizacionesRepositorio
    {
        private Conexion? conexion;

        public LocalizacionesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Localizaciones> Listar()
        {
            return conexion!.Listar<Localizaciones>();
        }

        public List<Localizaciones> Buscar(Expression<Func<Localizaciones, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Localizaciones Guardar(Localizaciones entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Localizaciones Modificar(Localizaciones entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Localizaciones Borrar(Localizaciones entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Localizaciones, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
