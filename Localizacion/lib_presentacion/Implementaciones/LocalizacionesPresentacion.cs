using lib_comunicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;

namespace lib_presentaciones.Implementaciones
{
    public class LocalizacionesPresentacion : ILocalizacionesPresentacion
    {
        private ILocalizacionesComunicacion? iComunicacion = null;
        public LocalizacionesPresentacion(ILocalizacionesComunicacion iComunicacion)
        {
            this.iComunicacion = iComunicacion;
        }
        public async Task<List<Localizaciones>> Listar()
        {
            var lista = new List<Localizaciones>();
            var datos = new Dictionary<string, object>();
            var respuesta = await iComunicacion!.Listar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Localizaciones>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }
        public async Task<List<Localizaciones>> Buscar(Localizaciones entidad, string tipo)
        {
            var lista = new List<Localizaciones>();
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            datos["Tipo"] = tipo;
            var respuesta = await iComunicacion!.Buscar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Localizaciones>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }
        public async Task<Localizaciones> Guardar(Localizaciones entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localizaciones>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
        public async Task<Localizaciones> Modificar(Localizaciones entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localizaciones>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
        public async Task<Localizaciones> Borrar(Localizaciones entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localizaciones>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

    }
}
