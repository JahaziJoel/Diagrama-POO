using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Empleado : MiembroDeLaComunidad
    {
        public string Puesto { get; set; }
        public decimal Salario { get; set; }

        public Empleado(int id, string nombre, string apellido, string puesto, decimal salario)
            : base(id, nombre, apellido)
        {
            Puesto = puesto;
            Salario = salario;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Salario: {Salario:C}");

        }
    }
}