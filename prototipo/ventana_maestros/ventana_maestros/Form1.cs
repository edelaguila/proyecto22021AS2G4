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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\fondo.jpg");
            BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;            
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            Form frm = new LoginMaestros();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
