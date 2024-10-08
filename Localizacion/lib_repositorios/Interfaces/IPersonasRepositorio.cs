﻿using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IPersonasRepositorio
    {
        void Configurar(string string_conexion);
        List<Personas> Listar();
        List<Personas> Buscar(Expression<Func<Personas, bool>> condiciones);
        Personas Guardar(Personas entidad);
        Personas Modificar(Personas entidad);
        Personas Borrar(Personas entidad);
        bool Existe(Expression<Func<Personas, bool>> condiciones);
    }
}
