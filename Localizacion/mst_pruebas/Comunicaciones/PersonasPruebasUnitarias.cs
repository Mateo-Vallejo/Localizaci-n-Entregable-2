using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;
using lib_entidades.Modelos;
using lib_utilidades;

namespace mst_pruebas.Comunicaciones
{
    [TestClass]
    public class PersonasPruebaUnitaria
    {
        private IPersonasComunicacion? iComunicacion = null;
        private Personas? entidad = null;
        private List<Personas>? lista = null;
        public PersonasPruebaUnitaria()
        {
            iComunicacion = new PersonasComunicacion();
        }
        [TestMethod]
        public void Executar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }
        private void Listar()
        {
            var datos = new Dictionary<string, object>();
            var task = iComunicacion!.Listar(datos);
            task.Wait();
            datos = task.Result;
            Assert.IsTrue(!datos.ContainsKey("Error"));
            lista = JsonConversor.ConvertirAObjeto<List<Personas>>(
            JsonConversor.ConvertirAString(datos["Entidades"]));
        }
        private void Buscar()
        {
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad!;
            datos["Tipo"] = "NOMBRE";
            var task = iComunicacion!.Buscar(datos);
            task.Wait();
            datos = task.Result;
            Assert.IsTrue(!datos.ContainsKey("Error"));
            lista = JsonConversor.ConvertirAObjeto<List<Personas>>(
            JsonConversor.ConvertirAString(datos["Entidades"]));
        }
        public void Guardar()
        {
            var datos = new Dictionary<string, object>();
            entidad = new Personas()
            {
                
            };
            datos["Entidad"] = entidad!;
            var task = iComunicacion!.Guardar(datos);
            task.Wait();
            datos = task.Result;
            Assert.IsTrue(!datos.ContainsKey("Error"));
            entidad = JsonConversor.ConvertirAObjeto<Personas>(
            JsonConversor.ConvertirAString(datos["Entidad"]));
        }
        public void Modificar()
        {
            var datos = new Dictionary<string, object>();
            entidad!.Final = 3.0m;
            datos["Entidad"] = entidad!;
            var task = iComunicacion!.Modificar(datos);
            task.Wait();
            datos = task.Result;
            Assert.IsTrue(!datos.ContainsKey("Error"));
            entidad = JsonConversor.ConvertirAObjeto<Personas>(
            JsonConversor.ConvertirAString(datos["Entidad"]));
        }
        public void Borrar()
        {
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad!;
            var task = iComunicacion!.Borrar(datos);
            task.Wait();
            datos = task.Result;
            Assert.IsTrue(!datos.ContainsKey("Error"));
            entidad = JsonConversor.ConvertirAObjeto<Personas>(
            JsonConversor.ConvertirAString(datos["Entidad"]));
        }
    }
}

