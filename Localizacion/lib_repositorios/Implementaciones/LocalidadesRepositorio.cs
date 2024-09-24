using lib_entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class LocalidadesRepositorio : ILocalizacionesRepositorio
    {
        private Conexion? conexion;

        public LocalidadesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Localidades> Listar()
        {
            return conexion!.Listar<Localidades>();
        }

        public List<Localidades> Buscar(Expression<Func<Localidades, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Localidades Guardar(Localidades entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Localidades Modificar(Localidades entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Localidades Borrar(Localidades entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Localidades, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
