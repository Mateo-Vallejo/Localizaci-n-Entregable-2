using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas
{
    [TestClass]
    public class PruebaUnitariaUbicaciones
    {
        private IUbicacionesRepositorio? iRepositorio = null;
        private Ubicaciones? entidad = null;

        public PruebaUnitariaUbicaciones()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_notas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
            iRepositorio = new UbicacionesRepositorio(conexion);
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
            entidad = new Ubicaciones()
            {
                Latitud = 11.22,
                Longitud = 33.44,
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}