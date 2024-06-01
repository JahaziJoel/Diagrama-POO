using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class ExAlumno : MiembroDeLaComunidad
    {
        public string AñoGraduacion { get; set; }

        public ExAlumno(int id, string nombre, string apellido, string añoGraduacion)
            : base(id, nombre, apellido)
        {
            AñoGraduacion = añoGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");

        }
    }
}