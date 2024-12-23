﻿using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class UbicacionesRepositorio : IUbicacionesRepositorio
    {
        private Conexion? conexion;

        public UbicacionesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Ubicaciones> Listar()
        {
            return conexion!.Listar<Ubicaciones>();
        }

        public List<Ubicaciones> Buscar(Expression<Func<Ubicaciones, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Ubicaciones Guardar(Ubicaciones entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Ubicaciones Modificar(Ubicaciones entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public Ubicaciones Borrar(Ubicaciones entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Ubicaciones, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }

        public void CalcularUbicacion()
        {
        }

        public void MostrarUbicacion()
        {
        }
    }
}