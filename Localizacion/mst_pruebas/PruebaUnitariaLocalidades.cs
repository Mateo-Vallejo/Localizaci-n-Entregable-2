using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas
{
    [TestClass]
    public class PruebaUnitariaLocalidades
    {
        private ILocalidadesRepositorio? iRepositorio = null;
        private Localidades? entidad = null;

        public PruebaUnitariaLocalidades()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_notas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
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