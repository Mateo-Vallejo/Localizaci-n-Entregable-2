using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IDetallesImagenesRepositorio
    {
        void Configurar(string string_conexion);
        List<DetallesImagenes> Listar();
        List<DetallesImagenes> Buscar(Expression<Func<DetallesImagenes, bool>> condiciones);
        DetallesImagenes Guardar(DetallesImagenes entidad);
        DetallesImagenes Modificar(DetallesImagenes entidad);
        DetallesImagenes Borrar(DetallesImagenes entidad);
        bool Existe(Expression<Func<DetallesImagenes, bool>> condiciones);
    }
}
