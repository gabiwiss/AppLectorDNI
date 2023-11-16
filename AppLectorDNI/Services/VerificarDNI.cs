using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLectorDNI.Services
{
    public class LectorService
    {
        public LectorService() { }

        public static bool VerificarDNI(object dato)
        {
            
            List<string> datosLista = dato.ToString().Split(',').ToList();

            string nuevoDato= datosLista[1].Remove(0,7);

            return nuevoDato.Count() == 8;
        }
    }

}
