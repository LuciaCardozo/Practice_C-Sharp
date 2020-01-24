using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pido un numero y muestro todos los numeros primos que tiene
namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int count;
            int i, j;
            Console.WriteLine("Ingrese un numero: ");
            number = Int32.Parse(Console.ReadLine());
            for (i=1; i<number; i++)
            {
                count = 0;
                for (j=1;j<number; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                 if(count == 2)
                {
                    Console.WriteLine("Numeros primos: {0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
