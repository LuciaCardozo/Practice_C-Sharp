using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int squaredNumber;
            int cubedNumber;
            int number;
            Console.WriteLine("Ingrese un numero: ");
            do
            {
                number = Int32.Parse(Console.ReadLine());//va dENTRO DEL DO WHILE
                if (number > 0)
                {
                    squaredNumber = (int)Math.Pow(number, 2);
                    cubedNumber = (int)Math.Pow(number, 3);
                    Console.WriteLine("Numero al cuadrado: {0}", squaredNumber);
                    Console.WriteLine("Numero al cubo: {0}", cubedNumber);                  
                }
                else
                {
                    Console.WriteLine("ERROR, reingresar numero: ");   
                }
            }while(number<=0);//MIENTRAS INGRESE UN NUMERO MENOR A O IGUAL 0 QUE VUELVA A PREGUNTAR
            Console.ReadKey();
        }
    }
}
