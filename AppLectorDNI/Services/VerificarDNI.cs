using AppLectorDNI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AppLectorDNI.Validations;

namespace AppLectorDNI.Services
{
    public class LectorService
    {
        public LectorService() { }

        public static bool VerificarDNI(object dato, TextoPDF textoPDF)
        {
            var dato1 = dato as TextBox;
            if (dato1.Text.Contains('"')) 
            { 
                Socio socio = new Socio(dato1.Text.Split('"')); 
                return textoPDF.devolverTexto().Contains(socio.ObtenerDNI().ToString());
            }
            else
            {
                if (Validaciones.ValidarNumero(dato1.Text))
                {
                    return textoPDF.devolverTexto().Contains(dato1.Text);
                }
                return false;
            }
            

            //return BuscarEnPdf.searchForText("C:\\Users\\gabi\\Source\\Repos\\gabiwiss\\AppLectorDNI\\AppLectorDNI\\LISTADO-DE-SOCIOS.pdf", socio.ObtenerDNI().ToString());

            
        }
    }

}

