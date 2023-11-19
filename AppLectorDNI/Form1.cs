using AppLectorDNI.Models;
using AppLectorDNI.Services;
using System.Windows.Forms;
namespace AppLectorDNI
{
    public partial class Form1 : Form
    {
        private readonly TextoPDF textoPDF;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            textoPDF = new TextoPDF(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LISTADO-DE-SOCIOS.pdf"));
            timer = new System.Windows.Forms.Timer();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox_Enter(object sender, KeyEventArgs e)
        {
            int i = 0;
            if (e.KeyCode == Keys.Enter)
            {
                timer.Start();
                if (LectorService.VerificarDNI(sender,textoPDF))
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

                
                timer.Interval = 60000; // 10 segundos

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
    }
}