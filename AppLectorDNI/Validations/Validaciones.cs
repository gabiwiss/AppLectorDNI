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
        private MatchCollection match;
        public Validaciones() 
        {
            
        }

        public static string ExtraerNumeros(string dato) 
        {   
            
            foreach (Match m in Regex.Matches(dato, @"\d*$"))
            {
                return m.Value;
            }
            return dato;
        }

        public static bool ValidarNumero(string dato) 
        {
            return Regex.IsMatch(dato, @"^\d{6,}$");
        }
    }
}   
