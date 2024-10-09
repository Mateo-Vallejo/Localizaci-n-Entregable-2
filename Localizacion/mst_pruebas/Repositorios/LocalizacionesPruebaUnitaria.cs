using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class LocalizacionesPruebaUnitaria
    {
        private ILocalizacionesRepositorio? iRepositorio = null;
        private Localizaciones? entidad = null;

        public LocalizacionesPruebaUnitaria()
        {
            var conexion = new Conexion();
            //conexion.StringConnection = "Server=CARZAXO\\DEV;Database=db_Localizacion;Integrated Security=True;TrustServerCertificate=True;";
            conexion.StringConnection = "server=CARZAXO;database=db_Localizacion;Integrated \r\nSecurity=True;TrustServerCertificate=true;";
            iRepositorio = new LocalizacionesRepositorio(conexion);
        }
        [TestMethod]
        public void Ejecutar()
        {
            Listar();
            Guardar();
        }
        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        private void Guardar()
        {
            entidad = new Localizaciones()
            {
                
                personas = 1,
                localidades = 1,
                ubicaciones = 1,
                imagenes = 1,
                detalles = 1,
                Hora = DateTime.Now.TimeOfDay,
                Activo = true,
                
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}