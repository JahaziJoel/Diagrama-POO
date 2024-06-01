using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }
        public int Año { get; set; }

        public Estudiante(int id, string nombre, string apellido, string carrera, int año)
            : base(id, nombre, apellido)
        {
            Carrera = carrera;
            Año = año;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Año: {Año}");

        }
    }
}