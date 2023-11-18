using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLectorDNI.Services
{
    public class TextoPDF
    {
        private readonly string Text;

        public TextoPDF (string path)
        {
            if (Text == null)
            {
                Text = ExtraerTexto.ExtractTextFromPdf(path);
            }
        }

       public string devolverTexto() { return Text; }
    }
}
