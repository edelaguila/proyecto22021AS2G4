using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventana_maestros
{
    public partial class LoginMaestros : Form
    {
        public LoginMaestros()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondo.jpg");
            BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();            
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaestros();
            frm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
