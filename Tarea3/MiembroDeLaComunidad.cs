using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class MiembroDeLaComunidad
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Apellido { get; }

        public MiembroDeLaComunidad(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        }
    }
}
