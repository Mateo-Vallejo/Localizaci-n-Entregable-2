using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class DetallesImagenesPruebaUnitaria
    {
        private IDetallesImagenesRepositorio? iRepositorio = null;
        private DetallesImagenes? entidad = null;

        public DetallesImagenesPruebaUnitaria()
        {
            var conexion = new Conexion();
            //conexion.StringConnection = "Server=CARZAXO\\DEV;Database=db_Localizacion;Integrated Security=True;TrustServerCertificate=True;";
            conexion.StringConnection = "server=localhost;database=db_facturas;Integrated \r\nSecurity=True;TrustServerCertificate=true;";
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
                Autor = "ITM",
                Titulo = "SEDE FRATERNIDAD",
                Fecha = DateTime.Now,
                Detalles = "Campus Universitario",
                Activo = true,
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
    }
}