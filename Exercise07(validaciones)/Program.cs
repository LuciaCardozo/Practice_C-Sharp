using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuit;
            string attempts;
            do
            {
                Console.WriteLine("\n*Ingrese cuit con 2 (-) unicamente putx: ");
                cuit = Console.ReadLine();
                if (!Functions.IsValidCuit(cuit))
                {
                    Console.WriteLine("\n\tERROOOOOR");
                }
                else
                {
                    Console.WriteLine("\n\tCuit ok perri");
                }
                Console.WriteLine("\n*Desea reintentar? (si-no)");
                attempts = Console.ReadLine();
            } while (attempts != "no");
            Console.WriteLine("\n\tGood bye!");
            Console.ReadKey();
        }
    }
}
