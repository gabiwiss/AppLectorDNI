using AppLectorDNI.Models;
using AppLectorDNI.Services;
namespace AppLectorDNI
{
    public partial class Form1 : Form
    {
        private readonly TextoPDF textoPDF;
        public Form1()
        {
            InitializeComponent();
            textoPDF = new TextoPDF("C:\\Users\\gabi\\Source\\Repos\\gabiwiss\\AppLectorDNI\\AppLectorDNI\\LISTADO-DE-SOCIOS.pdf");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (LectorService.VerificarDNI(sender,textoPDF))
                {
                    label2.Text = "SOCIO VERIFICADO";
                    //label2.BackColor = Color.LightSeaGreen;
                    label2.ForeColor = Color.Lime;
                    label2.Show();
                    /*MessageBox.Show(sender.ToString(), "mensaje correcto")*/
                }
                else
                {
                    label2.Text = "NO ENCONTRADO";
                    //label2.BackColor = Color.RosyBrown;
                    label2.ForeColor = Color.Red;
                    label2.Show();
                    /*MessageBox.Show(sender.ToString(), "mensaje incorrecto");*/
                }

                textBox1.Text = string.Empty;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}