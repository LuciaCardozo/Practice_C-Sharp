using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise07
{
    class Functions
    {
        public static bool IsValidName(string name)
        {
            Regex expression = new Regex(@"^[a-zA-Z]+$");
            if (expression.IsMatch(name))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsValidNumber(string number)
        {
            Regex expression = new Regex(@"^[0-9]+$");
            if (expression.IsMatch(number))
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsValidDni(string dni)
        {
            Regex expression = new Regex(@"^[0-9]{8}$");
            if (expression.IsMatch(dni))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsValidCuit(string cuit)
        {
            Regex expression = new Regex(@"^[0-9]{2}[-]{1}[0-9]{8}[-]{1}[0-9]{1}$");
            if (expression.IsMatch(cuit))
            {
                return true;
            }
            else
                return false;
        }
    }
}
