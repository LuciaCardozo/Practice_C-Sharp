using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numberMax = 0;
            int numberMin = 0;
            int result = 0;
            int len = 5;
            float average = 0; //promedio
            int i;
            for(i=0; i<len; i++)
            {
                Console.WriteLine("Ingrese Numero {0}", i);
                number = Int32.Parse(Console.ReadLine());
                if(numberMax<number)
                {
                    numberMax = number;
                }
                else if(numberMin>number)
                {
                    numberMin = number;
                }
                result += number;
            }
            average = (float)(result / len);
            Console.WriteLine("Numero minimo {0}", numberMin);
            Console.WriteLine("Numero maximo {0}", numberMax);
            Console.WriteLine("Numero promedio {0}", average);
            Console.ReadKey();
        }
    }
}
