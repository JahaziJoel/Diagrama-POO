using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Administrador : Docente
    {

        public Administrador(int id, string nombre, string apellido, string puesto, decimal salario, string departamento)
            : base(id, nombre, apellido, puesto, salario, departamento)
        {
        }
    }
}