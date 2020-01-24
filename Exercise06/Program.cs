using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pido la fecha y le muestro los dias que vive hasta la actualidad.
namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            int day,month,year,result;
            DateTime dateNew;
            Console.WriteLine("\tIngrese fecha de nacimiento\nDia");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mes");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Anio");
            year = Int32.Parse(Console.ReadLine());
            dateNew = new DateTime(year, month, day);
            result = (int)(date - dateNew).TotalDays;
            Console.WriteLine("{0} dias",result);
            Console.ReadKey();          
        }
    }
}
