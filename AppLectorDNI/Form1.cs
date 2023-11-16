using AppLectorDNI.Services;
namespace AppLectorDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                
                if(LectorService.VerificarDNI(sender))
                {
                    MessageBox.Show(sender.ToString(),"mensaje correcto");
                }
                else { MessageBox.Show(sender.ToString(), "mensaje incorrecto"); }
            }
        }
    }
}