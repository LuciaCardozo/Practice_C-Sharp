using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pido dos numeros y muestro los anios bisiestos en ese rango. 
namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numberTwo;
            Console.WriteLine("Ingrese un año de inicio: ");
            number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero de fin: ");
            numberTwo = Int32.Parse(Console.ReadLine());
            for(int i=number;i<=numberTwo;i++)
            {
                if(i%4==0 && i%400==0)
                {
                    Console.WriteLine("Numero: {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
