using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Maestro : Docente
    {
        public string Materia { get; set; }

        public Maestro(int id, string nombre, string apellido, string puesto, decimal salario, string departamento, string materia)
            : base(id, nombre, apellido, puesto, salario, departamento)
        {
            Materia = materia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");

        }
    }
}