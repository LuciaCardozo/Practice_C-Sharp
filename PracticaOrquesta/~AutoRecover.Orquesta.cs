using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOrquesta
{
    class Orquesta
    {
        public string nombre;
        public string lugar;
        public tipoOrquesta tipo;
        public List<Musico> musicos;

        public enum tipoOrquesta { Sinfonica, Camara, Filarmonica }

        public Orquesta() { }

        public Orquesta(string nombre, string lugar, tipoOrquesta orquesta)
        {
            this.nombre = nombre;
            this.lugar = lugar;
            this.tipo = orquesta;
            this.musicos = new List<Musico>();
        }
        public string getOrquestaString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre Orquesta: {0}, Lugar: {1}, Tipo: {2}\n", this.nombre, this.lugar, this.tipo);

            return sb.ToString();
        }

        public static void imprimirOrquesta(Orquesta or)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(or.getOrquestaString());
            if(or.musicos.Count>0)
            {
                sb.AppendFormat("Lista de Musico \n");
                foreach(Musico element in or.musicos)
                {
                    sb.AppendFormat("Musico: {0} {1}\n", element.nombre,element.apellido);
                    sb.AppendFormat("Instrumento: {0}\n", element.instrumento.nombre);

                }
            }
            Console.WriteLine("{0}", sb.ToString());
            Console.ReadLine();
        }
    }
}
