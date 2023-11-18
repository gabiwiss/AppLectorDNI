using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppLectorDNI.Validations
{
    public class Validaciones
    {
        public Validaciones() { }

        public static bool ValidarNumero(string dato) 
        {   
            return Regex.IsMatch(dato, @"^\d{8}$");
        }
    }
}
