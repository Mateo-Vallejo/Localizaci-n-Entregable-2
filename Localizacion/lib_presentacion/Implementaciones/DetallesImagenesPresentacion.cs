using lib_comunicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;

namespace lib_presentaciones.Implementaciones
{
    public class DetallesImagenesPresentacion : IDetallesImagenesPresentacion
    {
        private IDetallesImagenesComunicacion? iComunicacion = null;

        public DetallesImagenesPresentacion(IDetallesImagenesComunicacion iComunicacion)
        {
            this.iComunicacion = iComunicacion;
        }

        public async Task<List<DetallesImagenes>> Listar()
        {
            var lista = new List<DetallesImagenes>();
            var datos = new Dictionary<string, object>();
            var respuesta = await iComunicacion!.Listar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<DetallesImagenes>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }

        public async Task<List<DetallesImagenes>> Buscar(DetallesImagenes entidad, string tipo)
        {
            var lista = new List<DetallesImagenes>();
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            datos["Tipo"] = tipo;
            var respuesta = await iComunicacion!.Buscar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<DetallesImagenes>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }

        public async Task<DetallesImagenes> Guardar(DetallesImagenes entidad)
        {
            if (entidad.Id != 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            var respuesta = await iComunicacion!.Guardar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<DetallesImagenes>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

        public async Task<DetallesImagenes> Modificar(DetallesImagenes entidad)
        {
            if (entidad.Id == 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            var respuesta = await iComunicacion!.Modificar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<DetallesImagenes>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

        public async Task<DetallesImagenes> Borrar(DetallesImagenes entidad)
        {
            if (entidad.Id == 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            var respuesta = await iComunicacion!.Borrar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<DetallesImagenes>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
    }
}