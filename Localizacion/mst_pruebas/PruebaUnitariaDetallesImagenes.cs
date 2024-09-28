using lib_entidades;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas
{
    [TestClass]
    public class PruebaUnitariaDetallesImagenes
    {
        private IDetallesImagenesRepositorio? iRepositorio = null;
        private DetallesImagenes? entidad = null;

        public PruebaUnitariaDetallesImagenes()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_notas;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
            iRepositorio = new DetallesImagenesRepositorio(conexion);
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
            entidad = new DetallesImagenes()
            {
                Autor = "Test 1",
                Nombre = "Pepito Perez",
                Fecha = DateTime.Now,
                Detalles = "Foto",
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}