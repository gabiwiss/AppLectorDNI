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
            var textBox = dato as TextBox;
            var temp = "";
            if (textBox.Text.Contains('"')) 
            {
                try
                {
                    Socio socio = new Socio(textBox.Text.Split('"'));

                    temp=Validaciones.ExtraerNumeros(socio.ObtenerDNI());

                    if (Validaciones.ValidarNumero(temp))
                        return textoPDF.devolverTexto().Contains(temp);
                    else
                        return false;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                temp=Validaciones.ExtraerNumeros(textBox.Text);
                if (Validaciones.ValidarNumero(temp))
                    return textoPDF.devolverTexto().Contains(temp);
                else
                    return false;
            }
            

            //return BuscarEnPdf.searchForText("C:\\Users\\gabi\\Source\\Repos\\gabiwiss\\AppLectorDNI\\AppLectorDNI\\LISTADO-DE-SOCIOS.pdf", socio.ObtenerDNI().ToString());

            
        }
    }

}

