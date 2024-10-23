using lib_comunicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;

namespace lib_presentaciones.Implementaciones
{
    public class LocalidadesPresentacion : ILocalidadesPresentacion
    {
        private ILocalidadesComunicacion? iComunicacion = null;
        public LocalidadesPresentacion(ILocalidadesComunicacion iComunicacion)
        {
            this.iComunicacion = iComunicacion;
        }
        public async Task<List<Localidades>> Listar()
        {
            var lista = new List<Localidades>();
            var datos = new Dictionary<string, object>();
            var respuesta = await iComunicacion!.Listar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Localidades>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }
        public async Task<List<Localidades>> Buscar(Localidades entidad, string tipo)
        {
            var lista = new List<Localidades>();
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            datos["Tipo"] = tipo;
            var respuesta = await iComunicacion!.Buscar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Localidades>>(
            JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }
        public async Task<Localidades> Guardar(Localidades entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localidades>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
        public async Task<Localidades> Modificar(Localidades entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localidades>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
        public async Task<Localidades> Borrar(Localidades entidad)
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
            entidad = JsonConversor.ConvertirAObjeto<Localidades>(
            JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

    }
}
