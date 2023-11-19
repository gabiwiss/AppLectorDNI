using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLectorDNI.Models
{
    public class Socio
    {
        public Socio() { }

        public Socio(string[] datosSocio)
        {
            Numero = Convert.ToInt32(datosSocio[0]);
            Apellido = datosSocio[1];
            Nombre = datosSocio[2];
            Genero = datosSocio[3];
            DNI = datosSocio[4];
            Ejemplar = datosSocio[5];
            FechaNacimiento = DateOnly.Parse(datosSocio[6]);
            FechaDeEmision = DateOnly.Parse(datosSocio[7]);
            Numero2 = Convert.ToInt32(datosSocio[8]);
        }
        
        private int Numero { get; }
        private string Apellido { get; set; }
        private string Nombre { get; set; }
        private string Genero { get; set; }
        private string DNI { get; set; }
        private string Ejemplar { get; set; }
        private DateOnly FechaNacimiento { get; set; }
        private DateOnly FechaDeEmision { get; set; }
        private int Numero2 { get; set; }

        public string ObtenerDNI()
        {
            return DNI; 
        }
    }
}


