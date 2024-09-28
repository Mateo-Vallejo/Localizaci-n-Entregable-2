using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas
{
    [TestClass]
    public class PruebaUnitariaLocalizaciones
    {
        private ILocalizacionesRepositorio? iRepositorio = null;
        private Localizaciones? entidad = null;

        public PruebaUnitariaLocalizaciones()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_notas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
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
                ubicaciones = 1,
                localidades = 1,
                imagenes = 1,
                detalles = 1,
                Hora = DateTime.Now,
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}