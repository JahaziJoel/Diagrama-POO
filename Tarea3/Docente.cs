using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Docente : Empleado
    {
        public string Departamento { get; set; }

        public Docente(int id, string nombre, string apellido, string puesto, decimal salario, string departamento)
            : base(id, nombre, apellido, puesto, salario)
        {
            Departamento = departamento;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
}
