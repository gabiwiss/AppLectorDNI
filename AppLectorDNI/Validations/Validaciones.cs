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

        public static bool ValidarNumero(string dato) 
        {   
            
            foreach (Match m in Regex.Matches(dato, @"\d*$"))
            {
                Console.WriteLine(m.Value);
                return (m.Value != null);
               
            }
            return false;
        }
    }
}
