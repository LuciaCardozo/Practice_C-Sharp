using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrquesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Orquesta or = new Orquesta("Orquesta1", "Avellaneda", Orquesta.tipoOrquesta.Sinfonica);
            Console.WriteLine("Nombre: {0}, Lugar: {1}, Tipo: {2}", or.nombre, or.lugar, or.tipo);
            Console.ReadLine();

            Instrumento instrumento = new Instrumento("Guitarra", Instrumento.tipoInstrumento.Cuerdas);

            Musico musicoPrincipal = new Musico("Carla", "Perez", 26, instrumento);
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Tipo: {2}, \nInstrumento {3}\n", 
                musicoPrincipal.nombre, musicoPrincipal.apellido, musicoPrincipal.edad, 
                musicoPrincipal.instrumento.getInstrumentoString());
            Console.ReadLine();

            Musico m2 = new Musico("Pepe", "Grillo", 23, instrumento);

            or.musicos.Add(musicoPrincipal);
            or.musicos.Add(m2);
            Orquesta.imprimirOrquesta(or);

            Orquesta or2 = new Orquesta("Orquesta2", "Quilmes", Orquesta.tipoOrquesta.Camara);
        }
    }
}
