
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_utilidades;
using Microsoft.AspNetCore.Mvc;

namespace asp_servicios.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UbicacionesController : ControllerBase
    {
        private IUbicacionesAplicacion? IAplicacion = null;

        public UbicacionesController()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=CF-MP24ELZT\\DEV;database=db_facturas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
            IAplicacion = new UbicacionesAplicacion(
                new UbicacionesRepositorio(conexion));
        }

        [HttpGet]
        public IEnumerable<Ubicaciones> Get()
        {
            var lista = IAplicacion!.Listar();
            return lista.ToArray();
        }

        [HttpPost]
        public string Listar()
        {
            var respuesta = new Dictionary<string, object>();
            try
            {
                respuesta["Entidades"] = IAplicacion!.Listar();
                respuesta["Respuesta"] = "OK";
                respuesta["Fecha"] = DateTime.Now.ToString();
                return JsonHelper.ConvertirAString(respuesta);
            }
            catch (Exception ex)
            {
                respuesta["Error"] = ex.Message.ToString();
                return JsonHelper.ConvertirAString(respuesta);
            }
        }
    }
}
