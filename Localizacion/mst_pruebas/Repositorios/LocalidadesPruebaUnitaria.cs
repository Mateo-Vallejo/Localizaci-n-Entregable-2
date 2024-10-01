using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class LocalidadesPruebaUnitaria
    {
        private ILocalidadesRepositorio? iRepositorio = null;
        private Localidades? entidad = null;

        public LocalidadesPruebaUnitaria()
        {
            var conexion = new Conexion();
            //conexion.StringConnection = "Server=CARZAXO\\DEV;Database=db_Localizacion;Integrated Security=True;TrustServerCertificate=True;";
            conexion.StringConnection = "server=localhost;database=db_facturas;Integrated \r\nSecurity=True;TrustServerCertificate=true;";
            iRepositorio = new LocalidadesRepositorio(conexion);
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
            entidad = new Localidades()
            {
                Pais = "Colombia",
                Estado = "None",
                CodigoPostal = "05001",
                Ciudad = "Medellín",
                Barrio = "San Diego",
                Calle = "32",
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}