using AppLectorDNI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AppLectorDNI.Services
{
    public class LectorService
    {
        public LectorService() { }

        public static bool VerificarDNI(object dato)
        {
            var dato1 = dato as TextBox;
            Socio socio = new Socio(dato1.Text.Split('"'));

            return BuscarEnPdf.searchForText("C:\\Users\\gwissler\\source\\repos\\AppLectorDNI\\AppLectorDNI\\LISTADO-DE-SOCIOS.pdf", socio.ObtenerDNI().ToString());

            
        }
    }

}
