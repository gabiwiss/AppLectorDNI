using iText;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PdfSharp.Snippets.Drawing.ImageHelper;

namespace AppLectorDNI.Services
{
    public class BuscarEnPdf
    {
        public static bool searchForText(string path, string dni)
        {
            PdfReader pdfReader = new PdfReader(path);
            PdfDocument pdfParser = new PdfDocument(pdfReader);

            // extract the text
            var text =  ExtractTextFromPdf(pdfParser);

            return text.Contains(dni);   
        }

        public static string ExtractTextFromPdf(PdfDocument pdfDoc)
        {
            StringWriter output = new StringWriter();

            for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                ITextExtractionStrategy strategy = new LocationTextExtractionStrategy();
                string text = PdfTextExtractor.GetTextFromPage(page, strategy);
                output.WriteLine(text);
            }

            return output.ToString();
        }
    }
}
