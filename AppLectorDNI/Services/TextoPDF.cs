using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLectorDNI.Services
{
    public class TextoPDF
    {
        private string Text;

        public TextoPDF (string path)
        {
            if (Text == null)
            {
                if (File.Exists (path))
                {
                    Text = ExtraerTexto.ExtractTextFromPdf(path);
                }
                else { Text = "error"; }
                
            }
        }

        public string devolverTexto() { return Text; }
        public void guardarTexto(string text)
        { 
            Text=text; 
        }
    }
}
