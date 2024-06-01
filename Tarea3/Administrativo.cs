using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Administrativo : Empleado
    {
        public string Area { get; set; }

        public Administrativo(int id, string nombre, string apellido, string puesto, decimal salario, string Area)
            : base(id, nombre, apellido, puesto, salario)
        {
            Area = Area;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Area: {Area}");

        }
    }
}