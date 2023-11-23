using AppLectorDNI.Models;
using AppLectorDNI.Services;
using System.Windows.Forms;
namespace AppLectorDNI
{
    public partial class Form1 : Form
    {
        public TextoPDF textoPDF;
        public string directorio;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            directorio = AppDomain.CurrentDomain.BaseDirectory.Replace("\\net6.0-windows", "");
            textoPDF = new TextoPDF(Path.Combine(directorio, "marcos.pdf"));
            timer = new System.Windows.Forms.Timer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Enter(object sender, KeyEventArgs e)
        {
            int i = 0;
            if (e.KeyCode == Keys.Enter)
            {
                timer.Stop();
                timer.Start();
                if (LectorService.VerificarDNI(sender, textoPDF))
                {
                    label2.Text = "SOCIO VERIFICADO";
                    label2.ForeColor = Color.Lime;
                    label2.Show();
                }
                else
                {
                    label2.Text = "NO ENCONTRADO";
                    label2.ForeColor = Color.Red;
                    label2.Show();
                }


                timer.Interval = 10000; // 10 segundos

                timer.Tick += (sender, e) =>
                {
                    label2.Hide();
                    timer.Stop(); // Detiene el temporizador después de ocultar el mensaje
                };


                textBox1.Text = string.Empty;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar Archivo";
            /*openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";*/ // Solo archivos PDF

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog.FileName;

                // Crear una ruta temporal para el archivo
                string rutaTemporal = Path.GetTempFileName();

                // Copiar el archivo seleccionado a la ruta temporal
                File.Copy(nombreArchivo, rutaTemporal, true);

                // Obtener la ruta de la carpeta donde se encuentra el programa
                //string rutaPrograma = AppDomain.CurrentDomain.BaseDirectory.Replace("\\net6.0-windows","");

                // Combinar la ruta del programa con el nombre del archivo seleccionado
                string nuevaRuta = Path.Combine(directorio, Path.GetFileName(nombreArchivo));

                // Mover el archivo desde la ruta temporal a la carpeta del programa
            
                File.Move(rutaTemporal, nuevaRuta,true);

                Console.WriteLine("Archivo PDF guardado en: " + nuevaRuta);
            }
        }
    }
}